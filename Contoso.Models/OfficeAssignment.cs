using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Models
{
    public class OfficeAssignment
    {
        [Key]
        [ForeignKey("Instructor")]
        public int InstructorId { get; set; }

        [MaxLength(10)]
        [Display(Name= "Office Location")]
        public string Location { get; set; }

        public DateTime CreatedDate { get; set; }

        [MaxLength(20)]
        public string CreatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        [MaxLength(20)]
        public string UpdatedBy { get; set; }

        public int Id { get; set; }
        
        public virtual Instructor Instructor { get; set; }
    }
}
