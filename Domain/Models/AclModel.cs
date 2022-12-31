using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models
{
    public class AclModel
    {
        [Key]
        [ForeignKey("TextFileModel")]
        public String FileName { get; set; }
        public String Username { get; set; }
    }
}
