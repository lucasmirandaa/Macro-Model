using System.Diagnostics;
using Macro_Model.Models;
using Microsoft.AspNetCore.Mvc;

namespace Macro_Model.Controllers
{
	[Route("Cadastro")]
	public class CadastroController : Controller
	{
		public IActionResult Cadastro()
		{
		
			return View();
		}
	}
}
