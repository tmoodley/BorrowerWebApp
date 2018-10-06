using System;
using System.Collections.Generic;
using Data;
using Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BorrowerRegistrationApplication.Controllers
{
	[Route("api/[controller]")]
    [ApiController]
    public class BorrowerController : ControllerBase
    {
		private readonly IBorrowerService _borrowerService;

		public BorrowerController(IBorrowerService borrowerService)
		{
			_borrowerService = borrowerService;
		}

		[HttpGet]
		public IEnumerable<Borrower> Get()
		{
			return _borrowerService.GetAll();
		}

		[HttpGet("{id}", Name = nameof(Get))]
		public Borrower Get(Guid id)
		{
			return _borrowerService.GetById(id);
		}

		[HttpPost]
        public void Post(Borrower borrower)
        {
			_borrowerService.Create(borrower);
		}

        [HttpPut]
        public void Put([FromBody] Borrower borrower)
        {
			_borrowerService.Update(borrower);
		}

        [HttpDelete("{id}")]
        public void Delete(Guid id)
		{
			_borrowerService.Delete(id);
		}
    }
}
