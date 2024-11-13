using HRM.Repositories.Context;
using HRM.Repositories.Entities;
using HRM.Repositories.RepositoryClass.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Repositories.RepositoryClass.ImplementRepository
{
    public class EmployeeStatusRepository : IEmployeeStatusRepository
    {
        private readonly HRMContext _context;

        public EmployeeStatusRepository(HRMContext context)
        {
            _context = context;
        }
        public async Task<List<EmployeeStatus>> GetEmployeeStatuses(string? keyword)
        {
            var result = await _context.EmployeeStatuses.ToListAsync();
            return result;
        }
    }
}
