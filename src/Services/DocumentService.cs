using System.Linq;
using ShaBoo.Domain.Repositories;
using ShaBoo.Domain.Services;
using ShaBoo.Entities;

namespace ShaBoo.Services
{
    using System;

    public class DocumentService:IDocumentService
    {
        private IDALContext _context;
        public DocumentService(IDALContext context)
        {
            _context = context;
        }

        public IQueryable<Document> GetDocuments()
        {
            return _context.DocumentRepository.GetAll();
        }

        public Document GetDocument(int id)
        {
            return _context.DocumentRepository.GetByID(id);
        }

        public IQueryable<Document> GetDocumentsViaFstClassID(int id)
        {
            return _context.DocumentRepository
                .GetAll().Where(_ => _.FstClassID == id);
        }

        public void CreateNewUploadedDocument(
            string title, int fstClassID, int sndClassID, int trdClassID,
            string tags, string intro,
            string filePath, Int32 size, string suffix,
            short view, short download, DateTime uploadedOn, string userName)
        {
            var profile = _context.ProfileRepository.GetAll().FirstOrDefault(_ => _.UserName == userName);
            var newDocument = new Document
                                  {
                                      Title = title,
                                      FstClassID = fstClassID,
                                      SndClassID = sndClassID,
                                      TrdClassID = trdClassID, 
                                      Tags = tags,
                                      Intro = intro, 
                                      Path = filePath, 
                                      Size = size, 
                                      Suffix = suffix, 
                                      Views = view, 
                                      Downloads = download, 
                                      UploadedOn = uploadedOn, 
                                      ProfileID = profile.ID, 
                                  };
            _context.DocumentRepository.Insert(newDocument);
            _context.SaveChanges();
        }
    }
}
