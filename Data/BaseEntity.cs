using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{ 
	public abstract class EntityBase
	{
		public Guid Id { get; protected set; }
		public DateTime Created { get; set; }
	}
}
