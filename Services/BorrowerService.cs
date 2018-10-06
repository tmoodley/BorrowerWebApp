using Data;
using Interfaces; 
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services
{
	public class BorrowerService : IBorrowerService
	{ 
		private readonly IBorrowerRepository _borrowerRepository;
		public BorrowerService(IBorrowerRepository borrowerRepository)
		{
			_borrowerRepository = borrowerRepository;
		}
		//public ILogger Logger { get; set; }

		public void Create(Borrower input)
		{
			_borrowerRepository.Create(input);
		}

		public void Delete(Guid id)
		{
			_borrowerRepository.Delete(id);
		}

		public List<Borrower> GetAll()
		{
			return _borrowerRepository.GetAll();
		}

		public Borrower GetById(Guid id)
		{
			return _borrowerRepository.GetById(id);
		}

		public IEnumerable<Borrower> ListAll()
		{
			return _borrowerRepository.GetAll();
		}

		public void Update(Borrower input)
		{
			_borrowerRepository.Update(input);
		}
	}
}
