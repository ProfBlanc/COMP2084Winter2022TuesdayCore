using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace COMP2084Winter2022TuesdayCore.Models
{
    public class Folder
    {
        [Key]
        public int FolderID { get; set; }

        public string FolderName { get; set; }

        public int OwnerID { get; set; }

        [ForeignKey("OwnerID")]
        public Owner Owner { get; set; }

        /*
         *   any folder
         *      folder.ReferenceToChildTable.ChildTableField
         *      Folder folder = getFolderByID(1)
         *          
         *      
         *      folder.Owner.OwnerName
         */ 

    }
}
