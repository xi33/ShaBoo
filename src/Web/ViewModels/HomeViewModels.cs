using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShaBoo.Entities;

namespace ShaBoo.Web.ViewModels
{
    public class IndexViewModel
    {
        public IQueryable<FstClass> MainCategories { get; set; }
        public IQueryable<SndClass> SubCategories { get; set; }

        public IQueryable<Document> HotDocuments { get; set; }
        public IQueryable<Document> IndexDocuments { get; set; }

        public IList<CategoryWithDocuments> CategoryWithDocumentses { get; set; }

        public IQueryable<Board> Boards { get; set; } 

        public class CategoryWithDocuments
        {
            public FstClass MainCategory { get; set; }
            public IQueryable<Document> Documents { get; set; }
        }
    }

    public class BoardViewModel
    {
        public string Title { get; set; }
        public DateTime PostedOn { get; set; }
        public string Content { get; set; }
    }
}