using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Books.Models;

namespace Books.Controllers
{
    public class BookController : Controller
    {

        private static List<Book> Books = new List<Book>();
        // GET: Book
        public ActionResult Index()
        {
            return View(Books);
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            Book book = Books.Find(b => id == b.id);
            if(book != null)
            {
                return View(book);
            }

            return View();
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View();
        }
         
        // POST: Book/Create
        [HttpPost]
        public ActionResult Create(Book book)
        {
            try
            {
                // TODO: Add insert logic here
                Books.Add(book);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
            Book b = Books.Find(b1 => b1.id == id);
            if(b != null)
            {
                return View(b);
            }
            return View();
        }

        // POST: Book/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Book book)
        {
            try
            {
                // TODO: Add update logic here
                Book b = Books.Find(b1 => b1.id == id);
                if (b != null)
                {
                    Books[Books.IndexOf(b)] = book;
                    
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            Book b = Books.Find(b1 => b1.id == id);
            return View(b);
        }

        // POST: Book/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Book b = Books.Find(b1 => b1.id == id);
                Books.Remove(b);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
