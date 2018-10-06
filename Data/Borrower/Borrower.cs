using System;

namespace Data
{
	public class Borrower : EntityBase
	{  
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Gender { get; set; } 
		public string Login { get; set; }
		public string Password { get; set; } 
	}
}
