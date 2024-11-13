using HRM.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Repositories.RepositoryClass.Interface
{
    public interface IEmployeeStatusRepository
    {

        public Task<List<EmployeeStatus>> GetEmployeeStatuses(string? keyword);
    }
}
