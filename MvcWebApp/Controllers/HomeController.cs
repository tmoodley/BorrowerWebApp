using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using InterviewWebApp.Models;
using Data;
using Interfaces;
using Microsoft.Extensions.Logging;

namespace InterviewWebApp.Controllers
{
	public class HomeController : Controller
	{
		private readonly IBorrowerService _borrowerService;

		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger, IBorrowerService borrowerService)
		{
			_logger = logger;
			_borrowerService = borrowerService;
		}


		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(Borrower borrower)
		{
			_borrowerService.Create(borrower);
			return View();
		}

		public IActionResult About()
		{
			ViewData["Message"] = "Your application description page.";

			return View();
		}

		public IActionResult Contact()
		{
			ViewData["Message"] = "Your contact page.";

			return View();
		}

		public IActionResult Privacy()
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
