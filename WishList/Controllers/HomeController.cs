using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Note :il n'est pas nécessaire de spécifié la vue, elle est déduite du nom de l'action
            return View("Index");
        }

        public IActionResult Error()
        {
            return View("Error");
        }
    }
}
