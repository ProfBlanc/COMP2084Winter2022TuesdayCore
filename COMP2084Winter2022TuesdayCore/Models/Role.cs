using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP2084Winter2022TuesdayCore.Models
{
    public class Role
    {
        [Required]
        [MinLength(3, ErrorMessage = "Role must be at least 3 characters")]
        public string RoleName { get; set; }
    }
}
