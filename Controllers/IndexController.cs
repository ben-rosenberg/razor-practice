using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RazorFun.Controllers
{
    public class IndexController : Controller
    {
        [HttpGet("/")]
        public ViewResult Index()
        {
            return View();
        }
    }
}