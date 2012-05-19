using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShaBoo.Web.Controllers
{
    using ShaBoo.Domain.Services;
    using ShaBoo.Web.ViewModels;

    [Authorize(Roles = "User")]
    public class ProfileController : Controller
    {
        #region ctor
        private IBLLService _service;
        public ProfileController(IBLLService service)
        {
            _service = service;
        }
        #endregion

        public ActionResult Index(string name)
        {
            var model = new ProfileViewModels.IndexModel();
            model.Name = name;
            model.Point = _service.ProfileService.GetProfile(name).Point;

            model.UploadedDocuments = _service.DocumentService.GetDocuments().Where(_ => _.Profile.UserName == name);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Edit(ProfileViewModels.EditModel model)
        {


            return this.View(model);
        }

    }
}
