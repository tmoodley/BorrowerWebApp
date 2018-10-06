using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Interfaces;
using Microsoft.AspNetCore.Http;
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

		// GET: api/Borrower
		[HttpGet]
        public IEnumerable<Borrower> Get()
		{
			return _borrowerService.GetAll();
		}

        // GET: api/Borrower/5
        [HttpGet("{id}", Name = "Get")]
        public Borrower Get(Guid id)
        {
			return _borrowerService.GetById(id);
		}

        // POST: api/Borrower
        [HttpPost]
        public void Post([FromBody] Borrower borrower)
        {
			_borrowerService.Create(borrower); 
		}

        // PUT: api/Borrower/5
        [HttpPut]
        public void Put([FromBody] Borrower borrower)
        {
			_borrowerService.Update(borrower);
		}

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
		{
			_borrowerService.Delete(id);
		}
    }
}
