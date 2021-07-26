using Microsoft.AspNetCore.Mvc;
using ShopBHDT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using System.Dynamic;

namespace ShopBHDT.Controllers
{
    public class HomeController : Controller
    {

        ShopModel db = new ShopModel();
        public ActionResult Detail(int id)
        {
            return View(db.products.Where(c => c.productId == id).FirstOrDefault());
        }
        public ActionResult Index(int? page)
        {
            dynamic dy = new ExpandoObject();
            dy.top4Rate = GetTop4RateProduct();
            dy.top4LowPrice = GetTop4LowPriceProduct();
            dy.SanPhamMoi = GetSanPhamMoi();
            dy.TraGop0 = GetTraGop();
            dy.GiamGiaLon = GetGiamGiaLon();
            dy.GiaSocOnline = GetGiaSocOnline();
            return View(dy);
        }
        public ActionResult Iphone()
        {
            var alliphone = GetIPhone();
            return View(alliphone);
        }
        public ActionResult Samsung()
        {
            var allSamsung = GetSamsung();
            return View(allSamsung);
        }
        public ActionResult Oppo()
        {
            var allOppo = GetOppo();
            return View(allOppo);
        }
        public ActionResult Nokia()
        {
            var allNokia = GetNokia();
            return View(allNokia);
        }
        public ActionResult Huawei()
        {
            var allHuawei = GetHuawei();
            return View(allHuawei);
        }
        public ActionResult Xiaomi()
        {
            var allXiaomi = GetXiaomi();
            return View(allXiaomi);
        }
        public ActionResult Realme()
        {
            var allRealme = GetRealme();
            return View(allRealme);
        }
        public ActionResult Vivo()
        {
            var allVivo = GetVivo();
            return View(allVivo);
        }
        public ActionResult Philips()
        {
            var allPhilips = GetPhilips();
            return View(allPhilips);
        }
        public ActionResult Mobell()
        {
            var allMobell = GetMobell();
            return View(allMobell);
        }
        public ActionResult Mobiistar()
        {
            var allMobiistar = GetMobiistar();
            return View(allMobiistar);
        }
        public ActionResult Itel_Mobile()
        {
            var allItel_Mobile = GetItel_Mobile();
            return View(allItel_Mobile);
        }
        public ActionResult Coolpad()
        {
            var allCoolpad = GetCoolpad();
            return View(allCoolpad);
        }
        public ActionResult HTC()
        {
            var allHTC = GetHTC();
            return View(allHTC);
        }
        public ActionResult Motorola()
        {
            var allMotorola = GetMotorola();
            return View(allMotorola);
        }
        public List<product> GetTop4RateProduct()
        {
            var data = (from p in db.products
                        orderby p.rateCount descending
                        select p).Take(9);
            return data.ToList();
        }
        public List<product> GetTop4LowPriceProduct()
        {
            var data = (from p in db.products
                        orderby p.price ascending
                        select p).Take(8);
            return data.ToList();
        }
        public List<product> GetSanPhamMoi()
        {
            int id = 2;
            var data = (from p in db.products
                        where p.categoryId == id 
                        select p).Take(8);
            return data.ToList();
        }
        public List<product> GetTraGop()
        {
            int id = 3;
            var data = (from p in db.products
                        where p.categoryId == id
                        select p).Take(8);
            return data.ToList();
        }
        public List<product> GetGiamGiaLon()
        {
            int id = 4;
            var data = (from p in db.products
                        where p.categoryId == id
                        select p).Take(8);
            return data.ToList();
        }
        public List<product> GetGiaSocOnline()
        {
            int id = 5;
            var data = (from p in db.products
                        where p.categoryId == id
                        select p).Take(8);
            return data.ToList();
        }
        public List<product> GetIPhone()
        {
            int id = 1;
            var data = (from p in db.products
                        where p.companyId == id
                        select p);
            return data.ToList();
        }
        public List<product> GetSamsung()
        {
            int id = 2;
            var data = (from p in db.products
                        where p.companyId == id
                        select p);
            return data.ToList();
        }
        public List<product> GetOppo()
        {
            int id = 3;
            var data = (from p in db.products
                        where p.companyId == id
                        select p);
            return data.ToList();
        }
        public List<product> GetNokia()
        {
            int id = 4;
            var data = (from p in db.products
                        where p.companyId == id
                        select p);
            return data.ToList();
        }
        public List<product> GetHuawei()
        {
            int id = 5;
            var data = (from p in db.products
                        where p.companyId == id
                        select p);
            return data.ToList();
        }
        public List<product> GetXiaomi()
        {
            int id = 6;
            var data = (from p in db.products
                        where p.companyId == id
                        select p);
            return data.ToList();
        }
        public List<product> GetRealme()
        {
            int id = 7;
            var data = (from p in db.products
                        where p.companyId == id
                        select p);
            return data.ToList();
        }
        public List<product> GetVivo()
        {
            int id = 8;
            var data = (from p in db.products
                        where p.companyId == id
                        select p);
            return data.ToList();
        }
        public List<product> GetPhilips()
        {
            int id = 9;
            var data = (from p in db.products
                        where p.companyId == id
                        select p);
            return data.ToList();
        }
        public List<product> GetMobell()
        {
            int id = 10;
            var data = (from p in db.products
                        where p.companyId == id
                        select p);
            return data.ToList();
        }
        public List<product> GetMobiistar()
        {
            int id = 11;
            var data = (from p in db.products
                        where p.companyId == id
                        select p);
            return data.ToList();
        }
        public List<product> GetItel_Mobile()
        {
            int id = 12;
            var data = (from p in db.products
                        where p.companyId == id
                        select p);
            return data.ToList();
        }
        public List<product> GetCoolpad()
        {
            int id = 13;
            var data = (from p in db.products
                        where p.companyId == id
                        select p);
            return data.ToList();
        }
        public List<product> GetHTC()
        {
            int id = 14;
            var data = (from p in db.products
                        where p.companyId == id
                        select p);
            return data.ToList();
        }
        public List<product> GetMotorola()
        {
            int id = 15;
            var data = (from p in db.products
                        where p.companyId == id
                        select p);
            return data.ToList();
        }
        private List<Category> GetProductsList()
        {
            return db.Categories.ToList();
        }
    }
}