using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvitationWebApplication.Models;

namespace PartyInvitationWebApplication.Controllers
{
    public class LaguageFeatureController : Controller
    {
        // GET: LaguageFeature
        public ActionResult Index()
        {
            Products[] prodArr = new Products[]
            {
                new Products {Name = "apple", Price = 150 },
                new Products {Name = "Orrang", Price = 120 }
            };
            return View(prodArr);
        }

        public ViewResult CreateProduct()
        {
            var prodArray = new[]
            {
                new { ID = "1001", Name = "Rana"},
                new { ID = "1002", Name = "Mina"}
            };
            StringBuilder strBuilder = new StringBuilder();
            foreach (var data in prodArray)
            {
                strBuilder.Append(data.Name).Append("<-->");
            }
            ViewBag.strB = strBuilder;
            return View();
            //Products productObj = new Products
            //{
            //    Name = "Football",
            //    ProductID = "p1001",
            //    Description = "A ball for playing football.",
            //    Price = 550.00m,
            //    Category = "Outdoor sports"
            //};
            ////return View("Result", productObj);
            //return View("Result", (object)String.Format("Product Name : {0}", productObj.Name));
        }

        public ViewResult UseOfExtensionMethod()
        {
            IEnumerable<Products> shoppingCartObj = new ShoppingCart
            {
                ProductList = new List<Products>
                {
                    new Products {Name = "Kayak", Category = "Watersports", Price = 275M},
                    new Products {Name = "Soccer ball", Category = "Soccer", Price = 19.50M},
                    new Products {Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
                    new Products {Name = "Corner flag", Category = "Soccer", Price = 34.95M}
                }
            };

            Products[] ProductListOfArray =
            {
                new Products {Name = "Cricket Bat", Price = 1050 },
                new Products {Name = "Badminton Bat", Price = 460 },
                new Products {Name = "Football", Price = 200 }
            };

            decimal total = 0;

            //for filtering 
            //Func<Products, bool> catagotyFilt = prodData => prodData.Category == "Soccer";

            //Func<Products, bool> catagoryFilter = delegate (Products data)
            //{
            //    return data.Category == "Soccer";
            //};

            foreach (Products data in shoppingCartObj.Filter(prodData => prodData.Category == "Soccer" && prodData.Price > 20))
            {
                total += data.Price;
            }

            ViewBag.aaa = total;


            //List<String> hugeList = Enumerable.Range(1000, 200000).Select(n => n.ToString()).ToList();
            //StringBuilder stringBuilder = new StringBuilder();
            //String stringBuilderResult = "";
            //foreach (String s in hugeList)
            //{
            //    stringBuilder.Append(s);
            //}

            //stringBuilderResult = stringBuilder.ToString();
            //ViewBag.SB = stringBuilderResult;

            //var totalCartParice = shoppingCartObj.TotalPriceByFiltering("Soccer");
            //foreach (Products data in shoppingCartObj.TotalPriceByFiltering("Soccer"))
            //{
            //    total += data.Price;
            //}

            //decimal totalCartPriceInArray = ProductListOfArray.TotalCartPrice();
            //decimal totalCartParice = MyExtensionMethods.TotalCartPrice(shoppingCartObj);
            //ViewBag.totalCartParice = total;
            //ViewBag.totalCartPriceInArray = totalCartPriceInArray;
            return View();
            //return View("Result", (object)ViewBag.totalCartParice);
            //return View("Result", (object)String.Format("Cart Total :{o}", totalCartParice));
        }

        public ViewResult FindProducts()
        {
            List<Products> ProductList = new List<Products>
                {
                    new Products {Name = "Kayak", Category = "Watersports", Price = 275M},
                    new Products {Name = "Soccer ball", Category = "Soccer", Price = 19.50M},
                    new Products {Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
                    new Products {Name = "Corner flag", Category = "Soccer", Price = 34.95M}
                };

            //var foundProducts = from data in ProductList
            //                   orderby data.Price descending
            //                   select new { ProductName = data.Name, ProductPrice = data.Price };

            var foundProducts = ProductList.OrderByDescending(product => product.Price)
                                        .Take(3)
                                        .Select(product => new { product.Name, product.Price });
            int count = 0;
            StringBuilder result = new StringBuilder();
            foreach (var data in foundProducts )
            {
                //if (++count > 3)
                //{
                //    break;
                //}
                result.Append(data.Name).Append("--->").Append(data.Price).Append("\t");
            }
            ViewBag.result = result;
            return View();
        }


    }
}