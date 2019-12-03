using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC5Demo.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Column(TypeName = "varchar")]
        [Required]
        public string FullName { get; set; }
        [Column(TypeName = "varchar")]
        public string EmpCode { get; set; }
        [Column(TypeName = "varchar")]
        public string Position { get; set; }
        [Column(TypeName = "varchar")]
        public string OfficeLocation { get; set; }
    }
}