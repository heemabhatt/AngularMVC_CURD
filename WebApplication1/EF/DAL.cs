using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models;
namespace WebApplication1.EF
{
    public class DAL : DbContext
    {
        public DAL() : base("cnTest") { }
        public DbSet<Employee> employees {get;set;}
    }
}