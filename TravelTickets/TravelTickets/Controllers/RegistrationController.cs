using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelTickets.Models;

namespace TravelTickets.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
			RegistrationVModel model = new RegistrationVModel();
            return View(model);
        }
    }
}