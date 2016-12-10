using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.EF;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult GetAllEmployees()
        {
            DAL objDAL = new DAL();
            var employeeList = new List<Employee>();
            employeeList= objDAL.employees.ToList();
            return Json(employeeList,JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult AddEmployee(Employee Emp1)
        {
            DAL objDAL = new DAL();
            objDAL.employees.Add(Emp1);
            objDAL.SaveChanges();

            var employeeList = new List<Employee>();
            employeeList = objDAL.employees.ToList();
            return Json(employeeList, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetEmployeeById(int id1)
        {
            DAL objDAL = new DAL();
            Employee employee = new Employee();
            employee = objDAL.employees.Find(id1);
            return Json(employee, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult UpdateEmployee(Employee Emp1)
        {
            
            DAL objDAL = new DAL();
            objDAL.Entry(Emp1).State = System.Data.Entity.EntityState.Modified;
          
            objDAL.SaveChanges();
            var employeeList = new List<Employee>();
            employeeList = objDAL.employees.ToList();
            return Json(employeeList, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult DeleteEmployee(int id1)
        {

            DAL objDAL = new DAL();
            Employee Emp = new Employee();
            Emp = objDAL.employees.Find(id1);
            objDAL.Entry(Emp).State = System.Data.Entity.EntityState.Deleted;
            objDAL.SaveChanges();
            var employeeList = new List<Employee>();
            employeeList = objDAL.employees.ToList();
            return Json(employeeList, JsonRequestBehavior.AllowGet);
        }
    }
}