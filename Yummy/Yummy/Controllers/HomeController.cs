using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Yummy.Models;
using Microsoft.EntityFrameworkCore;

namespace Yummy.Controllers
{
    public class HomeController : Controller
    {
        private readonly YummyContext _yummyContext;

        public HomeController(YummyContext yummyContext)
        {
            _yummyContext = yummyContext;
        }

        public IActionResult Index()
        {
            List<Cheef> cheefs = _yummyContext.cheefs.ToList();
            return View(cheefs);
        }


        
    }
}