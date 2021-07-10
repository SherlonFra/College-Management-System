using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace College_Management_System.Models
{
    public class Student
    {
        [Required]
        public int StudentId { get; set; }
        [Required]
        public string FirstName { get; set; } 
        [Required]
        public string LastName { get; set; }

        [Required]
        public string EmailAddress { get; set; }

        [Required]
        public DateTime StudentBirthdate { get; set; }
        
        [Required]
        public int PhoneNumber { get; set; }
        
        [Required]
        public string Country { get; set; }



    }
}
