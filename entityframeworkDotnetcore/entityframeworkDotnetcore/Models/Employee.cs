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
        
        [DataType("nvarchar(50)")]
        [Display(Name ="Employee Name"),Required(ErrorMessage ="The Field is Requried")]
        public string EmployeName { get; set; }

        [DataType("nvarchar(50)")]        
        public string Position { get; set; }
        [DataType("nvarchar(50)")]
        public string OfficeLocation { get; set; }
    }
}
