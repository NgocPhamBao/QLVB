using System.Web.Mvc;

namespace QLVB.Areas.TroLy
{
    public class TroLyAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "TroLy";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "TroLy_default",
                "TroLy/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}