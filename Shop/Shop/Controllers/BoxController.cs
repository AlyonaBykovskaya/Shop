using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using Shop.Models;


namespace Shop.Controllers
{
    public class BoxController : Controller
    {
        [HttpGet]
        public ActionResult Box()
        {
            ViewBag.Message = "Оформление заказа";
            return View();
        }
      
    [HttpPost]
        public string Box(Order newOrder)
        {
        Order o =new Order();
            try{
                SmtpClient Smtp = new SmtpClient("smtp.gmail.com", 587);
                Smtp.Credentials = new NetworkCredential("alyonabykovskaya", "pass");
                //Smtp.EnableSsl = false;

                //Формирование письма
                MailMessage Message = new MailMessage();
                Message.From = new MailAddress(o.Email);
                Message.To.Add(new MailAddress("alyonabykovskaya@gmail.com"));
                Message.Subject = o.UserName;
                Message.Body = o.MessageText;

                Smtp.Send(Message);//отправка

                }catch(Exception)
                {
                    string Sorry;
                }
            return "Спасибо за заказ";
    }
        

    }
}
