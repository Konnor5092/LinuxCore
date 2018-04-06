using Microsoft.AspNetCore.Mvc;
using LinuxCore.Models;

namespace LinuxCore.Controllers
{
    public class HomeController : Controller 
    {
        public ViewResult Index()
        {
            Product myProduct = new Product 
            {
                ProductID = 1,
                Name = "Kayak",
                Description = "A boat for one person",
                Category = "Watersports",
                Price = 275M
            };

            return View(myProduct);
        }
    }
}