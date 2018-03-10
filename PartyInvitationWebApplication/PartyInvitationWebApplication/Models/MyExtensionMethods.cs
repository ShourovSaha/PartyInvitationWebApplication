using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartyInvitationWebApplication.Models
{
    public static class MyExtensionMethods
    {
        public static decimal TotalCartPrice(this IEnumerable<Products> enumParam)
        {
            decimal total = 0;
            foreach (Products data in enumParam)
            {
                total += data.Price;
            }
            return total;
        }

        public static IEnumerable<Products> TotalPriceByFiltering(this IEnumerable<Products> enumParum, string ProdCatagory)
        {
            decimal total = 0;
            foreach (Products data in enumParum)
            {
                if (data.Category == ProdCatagory)
                {
                    yield return data;
                    //total += data.Price;
                }
                
            }
            //return total;
        }


        public static IEnumerable<Products> Filter(this IEnumerable<Products> enumParum, Func<Products, bool> selectorParum)
        {
            foreach (Products data in enumParum)
            {
                if (selectorParum(data))
                {
                    yield return data;
                }
            }
        }
    }
}