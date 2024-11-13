using HRM.Services.DTOs.HRM.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Services.ServiceClass.HRM.Interface
{
    public interface IEmployeeStatusSevice
    {
        Task<ResultViewModel> GetEmployeeStatuses(string? keyword);
    }
}
