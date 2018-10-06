using Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
	public interface IRepository<T> where T : EntityBase
	{ 
		T GetById(Guid id);

		void Create(T entity);

		void Delete(T entity);

		void Update(T entity);

	}
}
