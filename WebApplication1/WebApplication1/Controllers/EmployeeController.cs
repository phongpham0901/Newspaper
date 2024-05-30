using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {

        public ActionResult Index()
        {
            var employees = from e in empList
                            orderby e.ID
                            select e;
            return View(employees);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection formCollection)
        {
            try
            {
                // ToDo add insert logic here
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            List<Employee> empList = GetEmployeeList();
            var employee = empList.Single(m => m.ID == id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var employee = empList.Single(m => m.ID == id);
                if (TryUpdateModel(employee))
                {
                    //To Do:- database code
                    return RedirectToAction("Index");
                }
                return View(employee);
            }
            catch
            {
                return View();
            }
        }


        public static List<Employee> empList = new List<Employee>{
   new Employee{
      ID = 1,
      Name = "Allan",
      JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
      Age = 23
   },

   new Employee{
      ID = 2,
      Name = "Carson",
      JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
      Age = 45
   },

   new Employee{
      ID = 3,
      Name = "Carson",
      JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
      Age = 37
   },

   new Employee{
      ID = 4,
      Name = "Laura",
      JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
      Age = 26
   },

};

        [NonAction]
        public List<Employee> GetEmployeeList()
        {
            return empList;
        }






        //// GET: Employee

        //public ActionResult Search(string name)
        //{
        //    var input = Server.HtmlEncode(name);
        //    return Content(input);
        //}

        //[HttpGet]
        //public ActionResult Search()
        //{
        //    var input = "Another Search action";
        //    return Content(input);
        //}
    }
}