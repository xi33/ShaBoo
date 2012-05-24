using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShaBoo.Domain.Services;
using ShaBoo.Web.Infrastructure;

namespace ShaBoo.Web.Controllers
{
    using System.IO;

    using ShaBoo.Web.ViewModels;

    public class HomeController : BaseController
    {
        private IBLLService _service;
        public HomeController(IBLLService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            ViewBag.Hello = "Hello World";
            ViewBag.Roles = _service.RoleService.GetAllRoles();
            ViewBag.Users = _service.UserService.GetAllUsers();
            return View();
        }

        public ActionResult Test()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Upload(string qqfile)
        {
            var path = Server.MapPath("~/App_Data");
            var file = Path.Combine(path, qqfile);
            using (var output = System.IO.File.OpenWrite(file))
            {
                Request.InputStream.CopyTo(output);
            }
            return Json(new { success = true });
        }

    }
}
