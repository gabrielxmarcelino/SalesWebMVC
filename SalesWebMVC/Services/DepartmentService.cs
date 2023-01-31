using SalesWebMVC.Data;
using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMVC.Services
{
	public class DepartmentsService
	{
		private readonly SalesWebMVCContext _context;

		public DepartmentsService(SalesWebMVCContext context)
		{
			_context = context;
		}

		public async Task<List<Department>> FindAllAsync()
		{
			return await _context.Department.OrderBy(x => x.Name).ToListAsync();
		}
	}
}
