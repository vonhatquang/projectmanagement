﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;  
using Microsoft.AspNetCore.Authorization;  
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]  
        public IActionResult Index()
        {            
            /*if(!User.Identity.IsAuthenticated){
                //return RedirectToAction("Login","Account");
                //return RedirectToAction("Index","Home", new {area = "Finance"});
                //return RedirectToAction("About","Home", new {area = ""});
                return RedirectToAction("UserLogin","Account", new {area = ""});
            }*/
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
