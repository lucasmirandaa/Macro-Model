using System.Diagnostics;
using Macro_Model.Models;
using Microsoft.AspNetCore.Mvc;

namespace Macro_Model.Controllers
{
    
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();  
        }
		

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
