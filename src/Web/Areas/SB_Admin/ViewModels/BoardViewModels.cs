using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShaBoo.Entities;

namespace ShaBoo.Web.Areas.SB_Admin.ViewModels
{
    public class BoardViewModels
    {
        public class CreateBoradModel
        {
            [Display(Name = "标题")]
            public string Title { get; set; }
            [DataType(DataType.Date)]
            [Display(Name = "日期")]
            public DateTime PostedOn { get; set; }
            [Display(Name = "内容")]
            public string Content { get; set; }
        }

        public class ListBoardModel
        {
            public IQueryable<Board> Boards { get; set; }
        }
    }


}