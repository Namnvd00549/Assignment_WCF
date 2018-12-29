﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment_Client.Models;

namespace Assignment_Client.Controllers
{
    public class LoginController : Controller
    {
        AdminService adminService = new AdminService();
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            var result = adminService.Login(model);
            if (result == true)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Login","Login");
            }
        }
    }
}