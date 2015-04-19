using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace AspNetTester.Models
{
    public class ResponseViewModels
    {
        [Required(ErrorMessage = " Please enter your email address")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = " Please enter a valid email address")]
        public string Email { get; set; }
    }
}