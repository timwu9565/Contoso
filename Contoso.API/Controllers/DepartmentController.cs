using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Contoso.Service;
using Contoso.Models;
using System.Net.Http;
using System.Net;

namespace Contoso.API.Controllers
{
    [RoutePrefix("api/departments")]
    public class DepartmentController : ApiController
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService) 
        {
            _departmentService = departmentService;
        }

        //method
        [HttpGet]
        [Route("")]   
        // set as "getall" then at the end of URL, add "/getall"
        public IEnumerable<Department> GetDepartments() 
        {
            var departments = _departmentService.GetAllDepartments();
            return departments;
        }

        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult GetDepartmentById(int id)
        {
            var department = _departmentService.GetDepartmentById(id);
            if (department == null) 
            {
                var response = Request.CreateResponse(HttpStatusCode.NotFound, "No Deartment Found");
                return ResponseMessage(response);
            }


            return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, department));
        }
    }
}