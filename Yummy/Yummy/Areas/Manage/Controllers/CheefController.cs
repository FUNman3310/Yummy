using Microsoft.AspNetCore.Mvc;
using Yummy.Models;

namespace Yummy.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class CheefController : Controller
    {
        private readonly YummyContext _yummyContext;

        public CheefController(YummyContext yummyContext )
        {
            _yummyContext = yummyContext;
        }


        public IActionResult Index()
        {
            return View(_yummyContext.cheefs.ToList());
        }

        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cheef cheef)
        {
            string name = cheef.ImageFile.FileName;
            string path = "C:\\Users\\Fuad\\Desktop\\C#\\Yummy\\Yummy\\wwwroot\\Uploads\\Products\\" + name;

            using (FileStream fileStream = new FileStream(path, FileMode.Create))
            {
                cheef.ImageFile.CopyTo(fileStream);
            }

            

            _yummyContext.cheefs.Add(cheef);
            _yummyContext.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Update(int id)
        {
            Cheef cheef = _yummyContext.cheefs.Find(id);

            if (cheef == null) return View("Error");
            return View();
        }
        [HttpPost]
        public IActionResult Update(int id, Cheef cheef)
        {


            Cheef existCheef = _yummyContext.cheefs.FirstOrDefault(x => x.Id == id);
            if (existCheef == null) return View("Error");


            existCheef.FullName = cheef.FullName;
            existCheef.Job = cheef.Job;
            existCheef.Description = cheef.Description;
            existCheef.Image = cheef.Image;
            existCheef.facebook = cheef.facebook;
            existCheef.instagram = cheef.instagram;
            existCheef.linkedin = cheef.linkedin;
            existCheef.twitter = cheef.twitter;

            _yummyContext.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            return View("Index");
        }
        public IActionResult Delete(int id, Cheef cheef)
        {
            return View("Index");
        }
    }
}
