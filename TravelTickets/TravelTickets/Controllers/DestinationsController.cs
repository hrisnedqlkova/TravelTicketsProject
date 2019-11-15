using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using TravelTickets.Models;

namespace TravelTickets.Controllers
{
    public class DestinationsController : Controller
    {
        public IActionResult Index()
        {
			List<DestinationsVModel> list = new List<DestinationsVModel>();
            return View(list);
        }
    }
}