using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission9.Models;
using Mission9.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9.Controllers
{
    public class HomeController : Controller
    {
        private iBookRepository repo { get; set; }

        public HomeController (iBookRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index(int pageNum = 1)
        {
            int pageSize = 10;

            var x = new ProjectsViewModel
            {
                Books = repo.Books
                .OrderBy(p => p.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumBooks = repo.Books.Count(),
                    BooksPerPage = pageSize,
                    CurrentPage = pageNum

                 }
            };

            return View(x);
        }

    }
}
