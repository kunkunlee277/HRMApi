using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Repositories.Entities
{
    [Table("EmployeeStatuses", Schema = "HRM")]
    public class EmployeeStatus
    {
        [Key]
        public int StatusID { get; set; }
        public string StatusName { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
