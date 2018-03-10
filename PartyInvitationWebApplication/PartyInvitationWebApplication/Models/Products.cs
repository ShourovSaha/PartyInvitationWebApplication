using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartyInvitationWebApplication.Models
{
    public class Products
    {
        private string name { get; set; }
        public string ProductID { get; set; }
        public string Name
        {
            get
            {
                return name + ProductID;
            }
            set
            {
                name = value;
            }
        }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}