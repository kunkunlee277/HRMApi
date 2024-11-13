using HRM.Repositories.RepositoryClass.Interface;
using HRM.Services.DTOs.HRM.Responses;
using HRM.Services.ServiceClass.HRM.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Services.ServiceClass.HRM.ImplementServices
{
    public class EmployeeStatusSevice : IEmployeeStatusSevice
    {
        private readonly IEmployeeStatusRepository _employeeStatusRepository;

        public EmployeeStatusSevice(IEmployeeStatusRepository employeeStatusRepository)
        {
            _employeeStatusRepository = employeeStatusRepository;
        }

        public async Task<ResultViewModel> GetEmployeeStatuses(string? keyword)
        {
            ResultViewModel model = new ResultViewModel();
            try
            {
                var result = new List<EmployeeStatusResponse>();
                var data = await _employeeStatusRepository.GetEmployeeStatuses(keyword);
                foreach (var item in data)
                {
                    var itemNew = new EmployeeStatusResponse
                    {
                        StatusID = item.StatusID,
                        StatusName = item.StatusName
                    };
                    result.Add(itemNew);
                }

                model.status = 1;
                model.message = "Get list page size success!";
                model.response = result;
            }
            catch(Exception ex)
            {
                model.status = -1;
                model.message = "Service không hoạt động " + ex.Message.ToString();
            }

            return model;
        }
    }
}
