using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class ImmaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Route(string naam)
        {
            return $"ugh {naam}! Alles goed?";
        }
    }
}