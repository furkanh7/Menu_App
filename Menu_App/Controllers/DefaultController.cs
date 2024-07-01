using Menu_App.Context;
using Menu_App.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Menu_App.Controllers
{
    public class DefaultController : Controller
    {
        MenuContext context = new MenuContext();
        public IActionResult Index()

        {
            ViewBag.p1 = "250 yıllık sırlarla dolu özel odamıza hoşgeldiniz. Burası AcunMedya bir odaya sığan kocaman dostluklar, kutlamalar, özel anlaşmalar ve davetleri için AcunMedya tutkunlarına açıldı. Eski bir hikayede yeni uzun sofralar kurmak için rezervasyon yaptırmanız yeterli.";

            ViewBag.p2 = "İstanbul Boğazı’nın berrak maviliklerine komşu, lacivert suların beyaz köpüklü dalgalarına bakan eşsiz lezzetler; Lacivert’in sofistike atmosferinde usta eller tarafından sunulmaya devam ediyor. Dünyanın en seçkin restoran derecelendirme rehberlerinden Gault & Millau İstanbul seçkisinde Deniz Ürünleri kategorisinde ödül alan Lacivert, gündüz ayrı, gece ise apayrı bir Boğaz manzarası ile misafirlerini büyülüyor. Derin maviliklerden, Akdeniz’den ve doğanın armağan ettiği eşsiz malzemelerden oluşan çok özel lezzetler unutulmaz bir yemek deneyimi yaşatıyor.";
           
            
            return View();
        }
        public PartialViewResult PartialHead()
        {

            return PartialView();

        }
        public PartialViewResult PartialNavBar()
        {

            return PartialView();

        }
        public PartialViewResult PartialCarousel()
        {

            return PartialView();

        }
        public PartialViewResult PartialScript()
        {

            return PartialView();

        }
        public PartialViewResult PartialFooter()
        {

            return PartialView();

        }
        public PartialViewResult PartialContact()
        {
            return PartialView();

        }
        public PartialViewResult PartialTestimonial()
        {
            return PartialView();

        }
        public PartialViewResult PartialTeam()
        {
            //var values = context.Chefs.Where(x => x.Status == true).ToList();

            return PartialView();

        }
        public PartialViewResult PartialFeature()
        {
            return PartialView();

        }
        public PartialViewResult PartialAbout()
        {
            return PartialView();

        }
        [HttpGet]
        public PartialViewResult CreateBooking()
        {
           
            return PartialView();

        }

        [HttpPost]

        public IActionResult CreateBooking(Booking booking)
        {
            booking.Description = "Rezervasyon Alındı";
            context.Bookings.Add(booking);
            context.SaveChanges();
            return RedirectToAction("Index");

        }




    }
}
