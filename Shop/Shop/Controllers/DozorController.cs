using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shop.Models;

namespace Shop.Controllers
{
    public class DozorController : Controller
    {
        public Book b = new Book();
        //
        // GET: /Dozor/

        public ActionResult Dozor()
        {
            var allBooks = b.ReadBooks(Server.MapPath("~/Data/Книги.csv"));
            return View(allBooks);
        }

    }
}
