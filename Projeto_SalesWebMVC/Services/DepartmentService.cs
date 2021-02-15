using Projeto_SalesWebMVC.Data;
using Projeto_SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Projeto_SalesWebMVC.Services
{
    public class DepartmentService
    {
        private readonly Projeto_SalesWebMVCContext _context;

        public DepartmentService(Projeto_SalesWebMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
