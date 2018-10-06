﻿using Data;
using EntityFrameworkCore;
using Interfaces;
using Microsoft.Extensions.Logging;
using NLog;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories
{ 
	public class BorrowerRepository : IBorrowerRepository
	{
		private readonly BorrowerDbContext _context;
		private readonly ILoggerFactory _loggerFactory;

		public BorrowerRepository(ILoggerFactory loggerFactory, BorrowerDbContext context)
		{
			_loggerFactory = loggerFactory;
			_context = context; 
		}
		 
		//Write your code here to implement each of the methods of the IRepository interface.
		public void Create(Borrower entity)
		{ 
			using (var transaction = _context.Database.BeginTransaction())
				{
					try
					{
						entity.Created = DateTime.Now; 
						_context.Borrowers.Add(entity);
						_context.SaveChanges(); 

						// Commit transaction if all commands succeed, transaction will auto-rollback
						// when disposed if either commands fails
						transaction.Commit();
					}
					catch (Exception e)
					{
						var logger = _loggerFactory.CreateLogger("BorrowerRepository Create()");
						logger.LogInformation(e.Message);
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
					catch (Exception e)
					{
						var logger = _loggerFactory.CreateLogger("BorrowerRepository Delete()");
						logger.LogInformation(e.Message);
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
					catch (Exception e)
					{
						var logger = _loggerFactory.CreateLogger("BorrowerRepository Update()");
						logger.LogInformation(e.Message);
					}
				}
			}
		}
	}
}
