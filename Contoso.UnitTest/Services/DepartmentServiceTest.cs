using System;
using Microsoft.VisualStudio.TestTools.UnitTesting; //MS Test for unit test
using Contoso.Service;
using Contoso.Data;
using Contoso.Models;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using Moq;

namespace Contoso.UnitTest.Services
{
    [TestClass]
    public class DepartmentServiceTest
    {
        private IDepartmentService _departmentService;
        private Mock<IDepartmentRepository> _mockDepartmentRepository; //initilize teh instance
        private List<Department> _departments;

        [TestInitialize]
        public void Initialize() 
        {
            _mockDepartmentRepository = new Mock<IDepartmentRepository>();
            //during the runtime automatically create it one time to implement the interface, delate the class created before
            _departmentService = new DepartmentService(_mockDepartmentRepository.Object); //.Object to create a object
            _departments = new List<Department>
            {
                new Department { Id = 1, Name = "CS", Budget = 300, StartDate = DateTime.Now },
                new Department { Id = 2, Name = "Math", Budget = 400, StartDate = DateTime.Now },
                new Department { Id = 3, Name = "Art", Budget = 500, StartDate = DateTime.Now },
                new Department { Id = 4, Name = "EE", Budget = 600, StartDate = DateTime.Now }
            };
            //sertup method bind the getall method with specific returns result to test if theyare equal  
            _mockDepartmentRepository.Setup(d => d.GetAll()).Returns(_departments);
            //set up the method getbyid and return the firstordefault of the list _departments 
            _mockDepartmentRepository.Setup(d => d.GetById(It.IsAny<int>())).Returns((int s) => _departments.First(x => x.Id == s));
        }

        public void CheckDepartmentNameFromFakeData() 
        {
            var departments = _departmentService.GetDepartmentById(3); //put any integer, the 3rd department is Art
            Assert.AreEqual("Art", departments.Name);
        }

        [TestMethod]
        public void CheckDepartmentCountFromFakeData()
        //use data from in-memory to check the method, the method should be self-explanatory
        {
            //_departmentService = new DepartmentService(new MockDepartmentRepository());
            var departments = _departmentService.GetAllDepartments(); //Act
            //AAA:
            //Arrange: initialize object, create mock objects, or instances
            //Act: invoking the method or properties
            //Assert: verify the action method, make sure it behaves as expected

            //what to check
            Assert.IsNotNull(departments);
            Assert.AreEqual(4, departments.Count());

        }
    }

    //public class MockDepartmentRepository : IDepartmentRepository
    //{
    //    public void Add(Department entity)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Delete(Department entity)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Delete(Expression<Func<Department, bool>> where)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Department Get(Expression<Func<Department, bool>> where)
    //    {
    //        throw new NotImplementedException();
    //    }


    //    // HERE
    //    public IEnumerable<Department> GetAll()
    //    {
    //        var department = new List<Department>
    //        {
    //            new Department { Id = 1, Name = "CS", Budget = 300, StartDate = DateTime.Now },
    //            new Department { Id = 2, Name = "Math", Budget = 400, StartDate = DateTime.Now },
    //            new Department { Id = 3, Name = "Art", Budget = 500, StartDate = DateTime.Now },
    //            new Department { Id = 4, Name = "EE", Budget = 600, StartDate = DateTime.Now }
    //        };

    //        return department;
    //    }

    //    public Department GetById(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public int GetCount(Expression<Func<Department, bool>> filter = null)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Department GetDepartmentByName(string name)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public IEnumerable<Department> GetMany(Expression<Func<Department, bool>> where)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void SaveChanges()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Update(Department entity)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
