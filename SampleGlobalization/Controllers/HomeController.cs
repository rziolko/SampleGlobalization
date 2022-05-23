using SampleGlobalization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleGlobalization.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public ActionResult SimpleForm()
        {
            ViewBag.Message = "Your simple form page.";

            return View();
        }

        [HttpPost]
        [HandleError]
        public ActionResult SimpleForm(SimpleFormModel model)
        {
            //ModelState.(nameof(SimpleFormModel));
            if (!TryValidateModel(model, nameof(SimpleFormModel)))
            {
                return View(model);
            }

            BaseController.SimpleFormList.Add(model);

            return RedirectToAction("SimpleFormList");
        }

        public ActionResult SimpleFormList()
        {
            return View(BaseController.SimpleFormList.ToList());
        }
    }
}