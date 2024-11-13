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
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeStatus> EmployeeStatuses { get; set; }
        public DbSet<Department> Departments { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure Employee table
            modelBuilder.Entity<Employee>()
                .Property(e => e.Id)
                .HasDefaultValueSql("NEWID()");

            // Configure Department table
            modelBuilder.Entity<Department>()
                .HasOne(d => d.Manager)
                .WithMany()
                .HasForeignKey(d => d.ManagerID);

            // Configure relationships
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentID);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Status)
                .WithMany(s => s.Employees)
                .HasForeignKey(e => e.StatusID);
        }
    }
}
