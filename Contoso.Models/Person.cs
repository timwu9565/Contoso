using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }
        
        public DateTime DateofBirth { get; set; }

        
        [MaxLength(30)]
        public string Email { get; set; }
        
        public Int32 Phone { get; set; }

        [MaxLength(50)]
        public string AddressLine1 { get; set; }

        [MaxLength(50)]
        public string AddressLine2 { get; set; }

        public int UnitOrApartmentNumber { get; set; }

        [MaxLength(15)]
        public string City { get; set; }

        [MaxLength(15)]
        public string State { get; set; }

        public int ZipCode { get; set; }

        [MaxLength(20)]
        public string Password { get; set; }

        public string Salt { get; set; }

        public Boolean Islocked { get; set; }

        public DateTime LastLockedDateTime { get; set; }

        public int FailedAttempts { get; set; }

        public DateTime CreatedDate { get; set; }

        [MaxLength(20)]
        public string CreatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }
        
        [MaxLength(20)]
        public string UpdatedBy { get; set; }

        public ICollection<Role> Roles { get; set; }

    }
}
