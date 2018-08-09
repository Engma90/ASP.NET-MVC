using SimpleWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleWebApplication.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult DisplayCustomer()
        {
            var customer = new Customer(3,"Mohamed");

            return View(customer);
        }


        public ActionResult print()
        {
            return View();
        }

        [HttpPost]
        public ActionResult print(string name)
        {
            //ViewBag.result = Request.Params.Get("M");
            ViewBag.result = name;
            //ViewBag.obj = new Customer(4, "");

            var customer = new Customer(4, "Mohamed");

            return View(customer);
        }
    }
}