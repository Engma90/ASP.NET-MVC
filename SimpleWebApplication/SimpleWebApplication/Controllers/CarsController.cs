using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleWebApplication.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars
        //[Route("AllCars/Index")]
        //[Route("")] //Make as default page /
        //[Route("Cars")]
        //[Route("Cars/Index")]
        public ContentResult Index()
        {
            return Content("<h1>ssssss</h1>");
        }


        //public ActionResult Index()
        //{
        //    return View();
        //}
    }
}