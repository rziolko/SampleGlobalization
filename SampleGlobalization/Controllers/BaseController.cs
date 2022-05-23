using SampleGlobalization.Models;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Web.Mvc;

namespace SampleGlobalization.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(
          ActionExecutingContext filterContext)
        {
            string culture = filterContext.RouteData.Values["culture"]?.ToString()
                                ?? "pl";

            filterContext.ActionParameters["culture"] = culture;

            var cultureInfo = CultureInfo.GetCultureInfo(culture);

            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;

            base.OnActionExecuting(filterContext);
        }

        public ActionResult RedirectToLang()
        {
            return RedirectPermanent("/pl");
        }

        public static IList<SimpleFormModel> SimpleFormList { get; set; } = new List<SimpleFormModel>();
    }
}