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

		public bool Create(Borrower input)
		{
			// Check validation
			if (input.FirstName == "")
			{
				throw new ArgumentNullException("First Name needs a value");
			}
			else if (input.LastName == "")
			{
				throw new ArgumentNullException("Last Name needs a value");
			}
			else if (!Helper.EmailIsValid(input.Login))
			{
				throw new ArgumentOutOfRangeException("Email not valid");
			}
			else if (CheckEmail(input.Login))
			{
				throw new ArgumentOutOfRangeException("Email already exists!  Pick Unique Email.");
			}
			else if (input.Password == "")
			{
				throw new ArgumentNullException("Password needs a value");
			}

			try
			{
				_borrowerRepository.Create(input);
				return true;
			}
			catch (Exception)
			{
				return false;
			}

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

		public bool Update(Borrower input)
		{
			// Check validation
			if (input.FirstName == "")
			{
				throw new ArgumentNullException("First Name needs a value");
			}
			else if (input.LastName == "")
			{
				throw new ArgumentNullException("Last Name needs a value");
			}
			else if (!Helper.EmailIsValid(input.Login))
			{
				throw new ArgumentOutOfRangeException("Email not valid");
			}
			else if (input.Password == "")
			{
				throw new ArgumentNullException("Password needs a value");
			}

			try
			{
				_borrowerRepository.Update(input);
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}


		public bool CheckEmail(string email)
		{
			return _borrowerRepository.CheckEmail(email);
		}
	}
}
