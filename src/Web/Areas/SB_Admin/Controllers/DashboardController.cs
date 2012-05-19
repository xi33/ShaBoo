using System;
using System.Web.Mvc;
using ShaBoo.Domain.Services;
using ShaBoo.Web.Areas.SB_Admin.ViewModels;
using ShaBoo.Web.Infrastructure;

namespace ShaBoo.Web.Areas.SB_Admin.Controllers
{
    public class DashboardController : BaseController
    {
        #region ctor
        private IBLLService _service;
        public DashboardController(IBLLService service)
        {
            _service = service;
        }
        #endregion

        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult Dashboard()
        {
            return Json(new { data = this.RenderPartialViewToString("_DashboardPartial") });
        }

        public ActionResult CreateBoard()
        {
            var model = new BoardViewModels.CreateBoradModel
            {
                Title = "请输入公告名称",
                PostedOn = DateTime.UtcNow
            };
            return Json(new { data = this.RenderPartialViewToString("_CreateBoardPartial", model) });
        }
    }
}
