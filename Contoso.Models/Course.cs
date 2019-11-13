using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Contoso.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Title { get; set; }

        [Required]
        public int Credits { get; set; }

        [Required]
        public int DepartmentID { get; set; }

        public DateTime CreatedDate { get; set; }
        
        [MaxLength(20)]
        public string CreatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        [MaxLength(20)]
        public string UpdatedBy { get; set; }

        public ICollection<Instructor> Instructors { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }

        public Department Department { get; set; }
    }
}
