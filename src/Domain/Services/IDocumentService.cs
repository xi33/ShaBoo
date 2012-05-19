using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShaBoo.Entities;

namespace ShaBoo.Domain.Services
{
    public interface IDocumentService
    {
        IQueryable<Document> GetDocuments();

        Document GetDocument(int id);

        IQueryable<Document> GetDocumentsViaFstClassID(int id);

        void CreateNewUploadedDocument(
            string title, int fstClassID, int sndClassID, int trdClassID,
            string tags, string intro,
            string filePath, Int32 size, string suffix,
            short view, short download, DateTime uploadedOn, string userName);

    }
}
