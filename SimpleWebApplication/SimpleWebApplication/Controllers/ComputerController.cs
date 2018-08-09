using SimpleWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleWebApplication.Controllers
{
    public class ComputerController : Controller
    {
        // GET: Computer
        public ActionResult Display()
        {
            Computer computer = new Computer();
            computer.name = "Lenovo";
            computer.price = 5000.00;
            return View(computer);
        }
    }
}