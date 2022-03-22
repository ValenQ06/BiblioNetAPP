using BiblioNetAPP.Models;
using BiblioNetAPP.Services;
using Microsoft.AspNetCore.Mvc;

namespace BiblioNetAPP.Controllers
{
    public class BooksController: Controller
    {
        private readonly IRepositorieBooks repositorieBooks;
        
        public BooksController(IRepositorieBooks repositorieBooks)
        {
            this.repositorieBooks = repositorieBooks;
        }
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

            books.Author = 1;
            books.Price = 1;
            repositorieBooks.Create(books);
            return View();
        }
    }
}
