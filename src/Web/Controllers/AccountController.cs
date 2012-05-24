using System;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using ShaBoo.Domain.Services;
using ShaBoo.Services.Providers;
using ShaBoo.Web.ViewModels;

namespace ShaBoo.Web.Controllers
{
    public class AccountController : Controller
    {

        public SBMembershipProvider MembershipService { get; set; }

        protected override void Initialize(RequestContext requestContext)
        {
            if (MembershipService == null)
                MembershipService = new SBMembershipProvider();

            base.Initialize(requestContext);
        }

        //
        // GET: /Account/LogOn
        public ActionResult LogOn()
        {
            return View();
        }

        //
        // POST: /Account/LogOn
        [HttpPost]
        public ActionResult LogOn(AccountViewModels.LogOnModel model, string returnUrl)
        {
            //if (ModelState.IsValid)
            //{
            if (MembershipService.ValidateUser(model.UserName, model.Password))
            {
                FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);
                if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                    && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                {
                    return Redirect(returnUrl);
                }
                return this.RedirectToAction("Index", "Home");
            }
            this.ModelState.AddModelError("", "The user name or password provided is incorrect.");
            return View(model);
        }

        //
        // GET: /Account/LogOff
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Home");
        }

        //
        // GET: /Account/Register
        public ActionResult Register()
        {
            return View();
        }

        //
        // POST: /Account/Register
        [HttpPost]
        public ActionResult Register(AccountViewModels.RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                // Attempt to register the user
                try
                {
                    MembershipService.CreateUser(model.UserName, model.Password, model.Email, "User");

                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return RedirectToAction("Index", "Home");
                }
                catch (ArgumentException ae)
                {
                    ModelState.AddModelError("", ae.Message);
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //todo 暂时没有实现 修改密码 功能
        ////
        //// GET: /Account/ChangePassword
        //[Authorize]
        //public ActionResult ChangePassword()
        //{
        //    return View();
        //}

        ////
        //// POST: /Account/ChangePassword
        //[Authorize]
        //[HttpPost]
        //public ActionResult ChangePassword(AccountViewModels.ChangePasswordModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (MembershipService.ChangePassword(User.Identity.Name, model.OldPassword, model.NewPassword))
        //            return RedirectToAction("ChangePasswordSuccess");
        //        else
        //            ModelState.AddModelError("", "The current password is incorrect or the new password is invalid.");
        //    }

        //    // If we got this far, something failed, redisplay form
        //    return View(model);
        //}

        ////
        //// GET: /Account/ChangePasswordSuccess
        //public ActionResult ChangePasswordSuccess()
        //{
        //    return View();
        //}

    }
}
