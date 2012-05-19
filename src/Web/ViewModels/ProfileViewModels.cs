using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShaBoo.Web.ViewModels
{
    using ShaBoo.Entities;

    public class ProfileViewModels
    {
        public class IndexModel
        {
            public string Name { get; set; }

            public int Point { get; set; }

            public IEnumerable<Document> UploadedDocuments { get; set; }
        }

        public class EditModel
        {
            public string Name { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string Alias { get; set; }

            public string Email { get; set; }

            public string Intro { get; set; }

            public int Point { get; set; }
        }

    }
}