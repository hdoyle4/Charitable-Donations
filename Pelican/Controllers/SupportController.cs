using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pelican.Models;

namespace Pelican.Controllers
{
    public class SupportController : Controller
    {
        private ISupportRepository repository;
        public SupportController(ISupportRepository repo)
        {
            repository = repo;
        }

        public ViewResult List() => View(repository.Supports);


        public IActionResult Submitted()
        {
            return View();
        }
    }
}