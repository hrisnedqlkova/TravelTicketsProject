using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelTickets.Models;

namespace TravelTickets.Controllers
{
	public class RegistrationController : Controller
	{
		TravelTicketsContext _context = new TravelTicketsContext();

		[HttpGet]
		public IActionResult Index()
		{
			RegistrationVModel model = new RegistrationVModel();
			return View(model);
		}
		[HttpPost]
		public async Task<IActionResult> Index(RegistrationVModel model)
		{
			if (ModelState.IsValid)
			{
				if (model.Password == model.ConfirmPassword)
				{
					Users entityUser = new Users();
					entityUser.FName = model.FName;
					entityUser.SName = model.SNAme;
					entityUser.LName = model.LName;
					entityUser.Phone = "";
					entityUser.Address = "";
					entityUser.City = "";
					entityUser.Country = model.Country;

					role roles =await  _context.Roles.FirstOrDefaultAsync(x => x.Id == 2);

					LoginModel login = new LoginModel();
					login.Email = model.Email;
					login.Password = model.Password;
					login.Role = roles;
					login.User = entityUser;

					_context.Add(entityUser);
					_context.Add(login);
					await _context.SaveChangesAsync();
				}
				else
				{
					ModelState.AddModelError(string.Empty, "Passeords is not match");
					return View(model);
				}
			}
			return View();
		}
	}
}