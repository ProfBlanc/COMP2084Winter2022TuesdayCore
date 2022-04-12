using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace COMP2084Winter2022TuesdayCore.Models
{
    public class Country
    {
        [Key]
        [Column(Order = 0, TypeName = "int")]
        public int CountryID { get; set; }
        
        [Required(ErrorMessage = "Country Name needed")]
        [MinLength(4, ErrorMessage = "Country Name needs to be at least 4 character")]
        [Column(Order = 1, TypeName = "varchar(50)")]
        public string CountryName { get; set; }

        [Required(ErrorMessage = "Leader required")]
        [MinLength(5, ErrorMessage = "Leader name needs to be at least 5 characters")]
        [Column(Order = 2, TypeName = "varchar(50)")]
        public string Leader { get; set; }
    }
}
