using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Invoice.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ViewResult Index()
        {
            return View("Index");
        }
    }
}
