using Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	public interface IBorrowerService
	{
		IEnumerable<Borrower> ListAll();
		bool Create(Borrower input);
		void Update(Borrower input);
		void Delete(Guid id);
		Borrower GetById(Guid id); 
		List<Borrower> GetAll(); 
	}
}
