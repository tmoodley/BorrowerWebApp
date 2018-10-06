using Data;
using Interfaces;
using System;
using System.Collections.Generic;

namespace Services
{
	public interface IBorrowerRepository 
	{
		Borrower GetById(Guid id);

		void Create(Borrower entity);

		void Delete(Guid id);

		void Update(Borrower entity);

		List<Borrower> GetAll();
	}
}