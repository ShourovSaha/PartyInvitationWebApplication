using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Claculator.Library;

namespace PartyInvitationWebApplication.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }

        Calculator calObj = new Calculator();

        [HttpGet]
        public ViewResult Divide()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Divide(int num1, int num2)
        {
            ViewBag.Ans = calObj.Divide(num1, num2);
            return View();
        }
    }
}