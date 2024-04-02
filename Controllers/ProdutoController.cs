using System.Diagnostics;
using Macro_Model.Models;
using Microsoft.AspNetCore.Mvc;

namespace Macro_Model.Controllers
{
	[Route("Produto")]
	public class ProdutoController : Controller
	{
		public IActionResult Produto()
		{
		
			return View();
		}
	}
}
