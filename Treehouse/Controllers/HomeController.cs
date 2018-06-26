using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Treehouse.Helper;

namespace Treehouse.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var comment = ExternalService.ReadComment();
            // HACK: Service docs say it can handle up to 30 chars but it crashes.
            var fixedComment = ServiceHelper.TrimForExternalService(comment);
            ExternalService.UploadCommentUpTo30Chars(fixedComment);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            var shippingHelper = new ShippingHelper();

            ViewBag.Message = "Your contact page.";

            List<string> myStrings = new List<string>();

            myStrings.Add("string 1");
            myStrings.Add("string 2");

            WriteStringsToConsole(myStrings);

            return View();
        }

        private void WriteStringsToConsole(List<string> myStrings)
        {
            throw new NotImplementedException();
        }
    }
}