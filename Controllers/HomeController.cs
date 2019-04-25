using System;
using Microsoft.AspNetCore.Mvc;
using Working_with_VS.Models;
using System.Linq;

namespace Working_with_VS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View(SimpleRepository.SharedRepository.Products
            .Where(p=>p?.Price<50)); 
            //=> View(SimpleRepository.SharedRepository.Products);
            //=> View("Index2");
    }
}
