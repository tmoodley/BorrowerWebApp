using Microsoft.AspNetCore.Mvc;
using EntityFrameworkCore;
using System.Linq;

namespace BorrowerRegistrationApplication.Controllers
{
	public class BorrowersController : Controller
    {
        private readonly BorrowerDbContext _context;

        public BorrowersController(BorrowerDbContext context)
        {
            _context = context;
        }

		public IActionResult Index()
		{
			return View(_context.Borrowers.ToList());
		}

		[HttpGet]
		public IActionResult Edit()
		{
			return PartialView();
		}
	}
}
