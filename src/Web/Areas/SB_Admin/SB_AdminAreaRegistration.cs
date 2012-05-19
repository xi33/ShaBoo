using System.Web.Mvc;

namespace ShaBoo.Web.Areas.SB_Admin
{
    public class SB_AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "SB_Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "SB_Admin_default",
                "SB_Admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
