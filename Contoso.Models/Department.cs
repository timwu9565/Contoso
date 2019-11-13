using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        public decimal Budget { get; set; }

        public DateTime StartDate { get; set; }

        [Required]
        public int InstructorId { get; set; }

        public string RowVersion { get; set; }

        public DateTime CreatedDate { get; set; }

        [MaxLength(10)]
        public string CreatedBy { get; set; }
        
        public DateTime UpdatedDate { get; set; }

        [MaxLength(10)]
        public string UpdatedBy { get; set; }
        public ICollection<Course> Courses { get; set; }
        public Instructor Instructor { get; set; }
    }
}