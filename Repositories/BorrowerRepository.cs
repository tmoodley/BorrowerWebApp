using Data;
using EntityFrameworkCore;
using Interfaces;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories
{ 
	public class BorrowerRepository : IBorrowerRepository
	{
		private readonly BorrowerDbContext _context;

		public BorrowerRepository(BorrowerDbContext context)
		{
			_context = context;
		}
		//Write your code here to implement each of the methods of the IRepository interface.
		public void Create(Borrower entity)
		{
			using (var context = new BorrowerDbContext())
			{
				using (var transaction = context.Database.BeginTransaction())
				{
					try
					{
						context.Borrowers.Add(entity);
						context.SaveChanges(); 

						// Commit transaction if all commands succeed, transaction will auto-rollback
						// when disposed if either commands fails
						transaction.Commit();
					}
					catch (Exception)
					{
						// TODO: Handle failure
					}
				}
			}
		}

		public void Delete(Guid id)
		{
			var borrower = GetById(id);
			using (var context = new BorrowerDbContext())
			{
				using (var transaction = context.Database.BeginTransaction())
				{
					try
					{
						context.Borrowers.Remove(borrower);
						context.SaveChanges();

						// Commit transaction if all commands succeed, transaction will auto-rollback
						// when disposed if either commands fails
						transaction.Commit();
					}
					catch (Exception)
					{
						// TODO: Handle failure
					}
				}
			}
		}

		public List<Borrower> GetAll()
		{ 
				return _context.Borrowers.ToList(); 
		}

		public Borrower GetById(Guid id)
		{
			using (var context = new BorrowerDbContext())
			{
				return context.Borrowers.Find(id);
			}
		}

		public void Update(Borrower entity)
		{
			using (var context = new BorrowerDbContext())
			{
				using (var transaction = context.Database.BeginTransaction())
				{
					try
					{
						context.Borrowers.Update(entity);
						context.SaveChanges();

						// Commit transaction if all commands succeed, transaction will auto-rollback
						// when disposed if either commands fails
						transaction.Commit();
					}
					catch (Exception)
					{
						// TODO: Handle failure
					}
				}
			}
		}
	}
}
