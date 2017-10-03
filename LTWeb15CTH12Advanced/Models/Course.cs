using System;
using System.ComponentModel.DataAnnotations;

namespace LTWeb15CTH12Advanced.Models
{
    public class Course
    {
        public int Id { get; set; }

        public ApplicationUser Lecturer { get; set; }

        [Required]
        public string LecturerId { get; set; }

        [Required]
        [StringLength(500)]
        public string Place { get; set; }

        public DateTime DateTime { get; set; }

        public Category Category { get; set; }

        [Required]
        public byte CategoryId { get; set; }
    }
}