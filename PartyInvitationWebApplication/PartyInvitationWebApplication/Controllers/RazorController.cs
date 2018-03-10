using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvitationWebApplication.Models;
namespace PartyInvitationWebApplication.Controllers
{
    public class RazorController : Controller
    {
        // GET: Razor
        Products myProdObj = new Products {
            ProductID = "1001",
            Name = "Kayak",
            Description = "A boat for one person",
            Category = "Watersports",
            Price = 275M
        };


        public ActionResult Index()
        {
            return View(myProdObj);
        }

        public ActionResult ProductInfo()
        {
            ViewBag.ProductCount = 1;
            ViewBag.ExpressShip = true;
            ViewBag.ApplyDiscount = false;
            ViewBag.Supplier = null;

            return View(myProdObj);
        } 

    }
}