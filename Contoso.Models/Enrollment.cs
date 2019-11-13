using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Models
{
    public class Enrollment
    {
        public int Id { get; set; }

        [Required]
        public int CourseId { get; set; }

        [Required]
        public int StudentId { get; set; }

        public int Grade { get; set; }
        public DateTime CreatedDate { get; set; }

        [MaxLength(20)]
        public string CreatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        [MaxLength(20)]
        public string UpdatedBy { get; set; }
        public Course Courses { get; set; }
        public Student Students { get; set; }
    }
}
