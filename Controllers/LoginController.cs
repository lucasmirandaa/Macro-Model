using System.Diagnostics;
using Macro_Model.Models;
using Microsoft.AspNetCore.Mvc;

namespace Macro_Model.Controllers
{
	[Route("Login")]
	public class LoginController : Controller
	{
		public IActionResult Login()
		{
		
			return View();
		}
	}
}
