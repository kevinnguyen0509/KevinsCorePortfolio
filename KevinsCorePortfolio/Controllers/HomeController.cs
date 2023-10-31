using KevinsCorePortfolio.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KevinsCorePortfolio.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Portfolio()
		{
			return View();
		}

	}
}