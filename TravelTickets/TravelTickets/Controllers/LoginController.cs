using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess;
using Microsoft.AspNetCore.Mvc;
using TravelTickets.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TravelTickets.Controllers
{
	public class LoginController : Controller
	{
		TravelTicketsContext _context = new TravelTicketsContext();

		[HttpGet]
		public IActionResult Index()
		{
			LoginVModel model = new LoginVModel();
			return View(model);
		}
		[HttpPost]
		public async Task<IActionResult> Index(LoginVModel model)
		{
			if (ModelState.IsValid)
			{
				var isUserExist = await _context.LoginModels.Where(x => x.Email == model.Email).ToListAsync();

				if (isUserExist.Count == 0)
				{
					ModelState.AddModelError(string.Empty, "This user doesn't exist");
					return View();
				}
				else
				{
					// add information in session
					//go to hpme
					return Redirect("../Home/Index");
				}
			}
			return View();
		}
	}
}