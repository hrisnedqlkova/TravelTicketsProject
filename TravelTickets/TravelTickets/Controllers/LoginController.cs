using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelTickets.Models;

namespace TravelTickets.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
			LoginVModel model = new LoginVModel();
            return View(model);
        }
    }
}