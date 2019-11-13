using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contoso.Service;
using System.Data.SqlClient;
using Contoso.Models;
using Contoso.Web.Filters;

namespace Contoso.Web.Controllers
{
    [ContosoExceptionFilter]
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;

        }
        // GET: Department

        [HandleError]
        public ActionResult Index()
        {
            var departments = _departmentService.GetAllDepartments();
            //ViewData["depts"] = departments;
            ViewBag.DepartmentCount = departments.Count();
            return View(departments); //return view in same folder with same name
        }


        //pass information from view to controller:
        [HttpGet]
        // by default it is get
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Department department)
        {
            //get the data from formcollection and call service layer
            //save to database
            try
            {
                department.CreatedDate = DateTime.Now;
                department.UpdatedDate = DateTime.Now;
                department.InstructorId = 8;
                _departmentService.CreateDepartment(department);

                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View();
            }
        }

        

        [HttpGet]
        public ActionResult Edit(int id = 1)
        {
            var department = _departmentService.GetDepartmentById(id);
            return View(department);
        }

        [HttpPost]
        public ActionResult Edit(Department department)
        {
            try
            {
                //_departmentService.UpdateDepartment(department);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View();
            }
        }


    }
}