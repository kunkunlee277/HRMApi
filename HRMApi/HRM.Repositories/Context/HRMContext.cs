using HRM.Repositories.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Repositories.Context
{
    public class HRMContext : DbContext
    {
        public HRMContext(DbContextOptions options): base(options)
        {

        }

        #region DbSets
        public DbSet<EmployeeStatus> EmployeeStatus { get; set; }
        #endregion
    }
}
