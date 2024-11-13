using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Repositories.Entities
{
    public class Employee : BaseEntity
    {
        [Required, MaxLength(100)]
        public string FirstName { get; set; }

        [Required, MaxLength(100)]
        public string LastName { get; set; }

        [MaxLength(10)]
        public string Gender { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime HireDate { get; set; }

        [MaxLength(100)]
        public string Position { get; set; } // Changed JobTitle to Position

        public int DepartmentID { get; set; }

        public int StatusID { get; set; }

        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(255)]
        public string Address { get; set; }

        [MaxLength(255)]
        public string Education { get; set; }

        [MaxLength(255)]
        public string Experience { get; set; }

        public string Skills { get; set; } // Storing JSON formatted string for skills

        public Department Department { get; set; }
        public EmployeeStatus Status { get; set; }
    }
}
