using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartyInvitationWebApplication.Models
{
    public class ShoppingCart: IEnumerable<Products>
    {
        public List<Products> ProductList { get; set; }

        public IEnumerator<Products> GetEnumerator()
        {
            return ProductList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }
}