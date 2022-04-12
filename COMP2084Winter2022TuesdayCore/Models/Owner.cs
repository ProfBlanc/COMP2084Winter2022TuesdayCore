using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP2084Winter2022TuesdayCore.Models
{
    public class Owner
    {
        [Key]
        public int OwnerID { get; set; }

        [Required]
        public string OwnerName { get; set; }

        public IEnumerable<Folder> Folders { get; set; }
    }
}
