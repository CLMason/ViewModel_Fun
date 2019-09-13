using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModel_Fun.Models;

namespace ViewModel_Fun.Controllers
{
    public class HomeController : Controller
    {       
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            Content message = new Content()
            {
                message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            };
            return View(message);
        }
        [Route("numbers")]
        [HttpGet]
        public IActionResult Numbers()
        {
            Number n1 = new Number()
            {
                num = 1
            };
            Number n2 = new Number()
            {
                num = 2
            };
            Number n3 = new Number()
            {
                num = 3
            };
            Number n4 = new Number()
            {
                num = 4
            };
            Number n5 = new Number()
            {
                num = 5
            };

            List<Number> viewNum = new List<Number>()
            {
                n1, n2, n3, n4, n5
            };
            return View("Numbers", viewNum);
        }
        [Route("users")]
        [HttpGet]
        public IActionResult Users()
        {
             User u1= new User()
            {
                Firstname  = "Candace",
                Lastname = "Mason"
            };
            User u2 = new User()
            {
                Firstname = "William",
                Lastname = "Mason"
            };
            User u3 = new User()
            {
                Firstname = "Moose",
                Lastname ="Phillips"
            };
            User u4 = new User()
            {
                Firstname = "Sally",
                Lastname = "Sanderson"
            };
            User u5 = new User()
            {
                Firstname = "Terrance",
                Lastname = "Williams"
            };

            List<User> viewUser = new List<User>()
            {
                u1, u2, u3, u4, u5
            };
            return View("Users", viewUser);
        }
        [Route("user")]
        [HttpGet]
        public IActionResult User()
        {
           User name = new User
           {
               Firstname = "Moose",
               Lastname = "Phillips"
           };
           return View(model: name);
        }
    }
}
