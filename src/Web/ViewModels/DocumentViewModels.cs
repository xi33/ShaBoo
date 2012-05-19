using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShaBoo.Web.ViewModels
{
    public class DocumentViewModels
    {
        public class UploadModel
        {
            public string FileName { get; set; }
            [Display(Name = "文档标题")]
            public string Title { get; set; }
            [Display(Name = "第一层分类")]
            public int FstClass { get; set; }
            [Display(Name = "第二层分类")]
            public int SndClass { get; set; }
            [Display(Name = "第三层分类")]
            public int TrdClass { get; set; }
            [Display(Name = "标签")]
            public string Tags { get; set; }
            [Display(Name = "文档简介")]
            public string Intro { get; set; }

        }

        public class DownloadModel
        {
            public int ID { get; set; }

            public string Title { get; set; }

            public string Suffix { get; set; }

            public int Size { get; set; }

            public int Views { get; set; }

            public int Downloads { get; set; }

            public string User { get; set; }

            public DateTime UploadedOn { get; set; }

            public string Intro { get; set; }
        }
    }

}