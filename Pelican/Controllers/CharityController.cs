using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pelican.Models;

namespace Pelican.Controllers
{
    public class CharityController : Controller
    {
        private ICharityRepository repository;
        public CharityController(ICharityRepository repo)
        {
            repository = repo;
        }

        public ViewResult List() => View(repository.Charities);


        public IActionResult Submitted()
        {
            //p.Donate(5);
            return View();
        }
    }
}
