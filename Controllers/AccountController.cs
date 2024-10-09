using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using _72220556sampleWebApp.Data;
using _72220556sampleWebApp.Migrations.UserMigrations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace _72220556sampleWebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUser _userData;

        public AccountController (IUser user)
        {
            _userData = user;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
}
}