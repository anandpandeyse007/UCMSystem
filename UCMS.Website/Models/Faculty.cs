﻿using System.ComponentModel.DataAnnotations;

namespace UCMS.Website.Models
{
    public class Faculty
    {
        [Key]
        public int FacultyId { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [MinLength(5)]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last name is required.")]
        [MinLength(5)]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;
        public int RoleId { get; set; }


        // Navigation Properties      
        public List<Course> Courses { get; set; }
    }
}
