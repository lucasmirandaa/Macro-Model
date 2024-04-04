using System.Diagnostics;
using Macro_Model.Models;
using Microsoft.AspNetCore.Mvc;

namespace Macro_Model.Controllers
{
	[Route("Cadastro")]
	public class CadastroController : Controller
	{
		[HttpGet]
		public IActionResult Cadastro()
		{
		
			return View();
		}

		[HttpPost]
		public IActionResult Cadastro(Pessoa pessoa)
		{	
			if (ModelState.IsValid)
			{
				//
			}

			return View(pessoa);
		}
	}
}
