using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace COMP2084Winter2022TuesdayCore.Models
{
    public class Employee
    {

        [Required(ErrorMessage = "Custom Error Message")]
        [Range(1000000, 9999999)]
        [Column(Order = 0, TypeName = "int")]
        public int EmployeeID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)", Order = 1)]
        public string EmployeeName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(10)", Order = 2)]
        public string EmployeePosition { get; set; }

        [Required]
        [Column(Order = 3, TypeName = "int")]

        public int EmployeeAge { get; set; }
    }
}
