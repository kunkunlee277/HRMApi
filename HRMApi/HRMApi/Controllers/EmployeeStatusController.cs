using HRM.Services.DTOs.HRM.Responses;
using HRM.Services.ServiceClass.HRM.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMApi.Controllers
{
    public class EmployeeStatusController : ControllerBase
    {
        public readonly IEmployeeStatusSevice _employeeStatusSevice;

        public EmployeeStatusController(IEmployeeStatusSevice employeeStatusSevice)
        {
            _employeeStatusSevice = employeeStatusSevice;
        }

        [HttpGet("get_Employee_Status")]
        public async Task<IActionResult> GetEmployeeStatus(string? keyword)
        {
            ResultViewModel result = new ResultViewModel();
            result = await _employeeStatusSevice.GetEmployeeStatuses(keyword);
            return Ok(result);
        }

    }
}
