using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace entityframeworkDotnetcore.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        
        [Column("nvarchar(50)")]
        public string EmployeName { get; set; }
        [Column("nvarchar(50)")]
        public string Position { get; set; }
        [Column("nvarchar(50)")]
        public string OfficeLocation { get; set; }
    }
}
