using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LTWeb15CTH12Advanced.Models
{
    public class Category
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}