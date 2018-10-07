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
        public string Post(Borrower borrower)
        {
			try
			{
				_borrowerService.Create(borrower);
				return "true";
			}
			catch (Exception e)
			{
				var json = Newtonsoft.Json.JsonConvert.SerializeObject(e.Message);
				return json;
			}
		}

        [HttpPut]
        public string Put([FromBody] Borrower borrower)
        {
			try
			{
				_borrowerService.Update(borrower);
				return "true";
			}
			catch (Exception e)
			{
				var json = Newtonsoft.Json.JsonConvert.SerializeObject(e.Message);
				return json;
			}
		}

        [HttpDelete("{id}")]
        public bool Delete(Guid id)
		{
			try
			{
				_borrowerService.Delete(id);
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
    }
}
