using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Repositories.Entities
{
    public class Department
    {
        public int DepartmentID { get; set; }
        [Required, MaxLength(100)]
        public string DepartmentName { get; set; }

        public Guid? ManagerID { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public Guid? UpdatedBy { get; set; }
        public bool IsDelete { get; set; }

        public Employee Manager { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
