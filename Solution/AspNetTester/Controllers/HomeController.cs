using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using AspNetTester.Models;

namespace AspNetTester.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        

        [HttpGet]
        public ViewResult Reg()
        {
            return View();
        }
        
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ViewResult Reg(ResponseViewModels response)
        {
            if (ModelState.IsValid)
            {
                return View("Success", response);
            }
            else
            {
                return View();
            }
        }
    }
}