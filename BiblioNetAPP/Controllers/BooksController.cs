using BiblioNetAPP.Models;
using Microsoft.AspNetCore.Mvc;

namespace BiblioNetAPP.Controllers
{
    public class BooksController: Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Books books)
        {
            if (!ModelState.IsValid)
            {
                return View(books);
            }
            return View();
        }
    }
}
