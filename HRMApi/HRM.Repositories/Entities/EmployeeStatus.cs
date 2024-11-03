using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Repositories.Entities
{
    [Table("EmployeeStatus", Schema = "HRM")]
    public class EmployeeStatus
    {
        [Key]
        public int StatusID { get; set; }
        public string StatusName { get; set; }
    }
}
