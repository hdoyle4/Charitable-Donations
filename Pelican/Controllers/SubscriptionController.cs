using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pelican.Models;

namespace Pelican.Controllers
{
    public class SubscriptionController : Controller
    {
        private ISubscriptionRepository repository;
        public SubscriptionController(ISubscriptionRepository repo)
        {
            repository = repo;
        }

        public ViewResult List() => View(repository.Subscriptions);


        public IActionResult Submitted()
        {
            return View();
        }
    }
}