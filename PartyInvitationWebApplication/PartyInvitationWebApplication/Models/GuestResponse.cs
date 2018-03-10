using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PartyInvitationWebApplication.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Enter your name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter your email ID.")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Plesae enter valid email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter your phone number.")]
        //[RegularExpression("0-9", ErrorMessage = "Plz valid phone number.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Ans this question")]
        public bool? WillAttend { get; set; }
             
    }
}