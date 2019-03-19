using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using USAG_Appl.Models;

namespace USAG_Appl.Controllers
{
    public class HomeController : Controller
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
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();

        }
        //public ActionResult Test()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}
        public ActionResult Test()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        //[HttpGet]
        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();

        //}

        //[HttpPost]
        //public ActionResult Contact(Merchant merchant)
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}

        //[HttpGet]
        //public ActionResult Test_Page()
        //{
        //    ViewBag.Message = "Your Layout Page";

        //    return View();

        //}

        //[HttpPost]
        //public ActionResult Test_Page(Merchant merchant)
        //{
        //    ViewBag.Message = "Your Layout Page";

        //    return View();
        //}


        [HttpGet]
        public ActionResult Test_Page()
        {
            ViewBag.Message = "Your Layout Page";

            return View();

        }

        [HttpPost]
        public ActionResult Test_Page(Merchant merchant)
        {

            return View("Test_Tab", merchant);
        }
        [HttpGet]

        public ActionResult Test_Tab()
        {
            return View();

        }

        [HttpPost]
        public ActionResult Test_Tab(Merchant merchant)
        {
            return View("tab3", merchant);

        }
        [HttpGet]
        public ActionResult tab3()
        {

            return View();
        }

        [HttpPost]
        public ActionResult tab3(Merchant merchant)
        {

            return View();
        }


        [HttpGet]
        public ActionResult Test1()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Test1(Merchant merchant)
        {
            //This ID will be generated from insert.
            merchant.ID = Guid.NewGuid();
            Guid id = merchant.ID;
            //Initialize new mercahnt variable with id that was just inserted.
            //Using Entity Framework, get Merchant ID ONLY and set it so that we can update on the next POST call.
            merchant = new Merchant() { ID=id };

            // return View("Test2",merchant);
            return RedirectToAction("Test2", merchant);
        }


        [HttpGet]
        public ActionResult Test2(Merchant merchant)
        {
            return View("Test2", merchant);
        }

        [HttpPost]
        public ActionResult submitTest2(Merchant merchant)
        {

            return View();
        }
        [HttpGet]
        public ActionResult ApplicationType()
        {

            return View();
        }

        [HttpPost]
        public ActionResult ApplicationType(Merchant merchant)
        {

            // return View("Test2",merchant);
            return RedirectToAction("Setup");
        }
        [HttpGet]
        public ActionResult Setup()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Setup(Merchant merchant)
        {

            // return View("Test2",merchant);
            return RedirectToAction("#");
        }

    }
}