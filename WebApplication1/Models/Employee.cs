using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("tblEmployee")]
    public class Employee
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public int Salary { get; set; }
        public string Post { get; set; }
    }
}