﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shop.Models;

namespace Shop.Controllers
{
    public class KulinarController : Controller
    {
        Book b=new Book();
        //
        // GET: /Kulinar/

        public ActionResult Kulinar()
        {
            var allBooks = b.ReadBooks(Server.MapPath("~/Data/Книги.csv"));
            return View(allBooks);
        }

    }
}
