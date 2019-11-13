using Contoso.Data;
using Contoso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(ContosoDbContext context) : base(context) //access base constructor 
        {
        }

        public Department GetDepartmentByName(string name)
        {
            var department = _dbContext.Departments.FirstOrDefault(d => d.Name == name);
            return department;
        }
    }

    public interface IDepartmentRepository : IRepository<Department> //has 10 + 1 methods
    {
        Department GetDepartmentByName(string name);
    }
}


//namespace Contoso.Data
//{
//    public class DepartmentRepository : IRepository<Department>
//    {
//        public void Create(Department d)
//        {
//            using (var db = new ContosoDbContext())
//            {
//                db.Departments.Add(d);
//                db.SaveChanges();
//            }
//        }

//        public IEnumerable<Department> GetAll()
//        {
//            //throw new NotImplementedException();
//            using (var db = new ContosoDbContext())
//            {
//                var result = db.Departments.ToList();
//                return result;
//            }
//        }

//        public Department GetById(int id)
//        {
//            //throw new NotImplementedException();
//            using (var db = new ContosoDbContext())
//            {
//                return db.Departments.Where(c => c.Id == id).FirstOrDefault();
//            }
//        }

//        public decimal GetByMax()
//        {
//            //throw new NotImplementedException();
//            using (var db = new ContosoDbContext())
//            {
//                var result = db.Departments.Max(x => x.Budget);
//                return result;
//            }
//        }

//        public Department GetByName(string name)
//        {
//            //throw new NotImplementedException();
//            using (var db = new ContosoDbContext())
//            {
//                var result = db.Departments.Where(x => x.Name == name).SingleOrDefault();
//                return result;
//            }
//        }

//        public void Update(Department d)
//        {
//            //throw new NotImplementedException();
//            using (var db = new ContosoDbContext())
//            {
//                var res = db.Departments.Where(x => x.Id == d.Id).FirstOrDefault();
//                res.Id = d.Id;
//                res.Name = d.Name;
//                res.Budget = d.Budget;
//                res.StartDate = d.StartDate;
//                res.InstructorId = d.InstructorId;
//                res.UpdatedBy = d.UpdatedBy;
//                db.SaveChanges();
//            }
//        }

//    }
//}
