using ShopBHDT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopBHDT.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        ShopModel db = new ShopModel();
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(admin avm)
        {
            admin ad = db.admins.Where(x => x.username == avm.username && x.password == avm.password).SingleOrDefault();
            if (ad != null)
            {
                Session["id"] = ad.id.ToString();
                return RedirectToAction("Home");
            }
            else
            {
                ViewBag.error = "Invalid username or password";
            }
            return View();
        }
    }
}