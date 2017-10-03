using LTWeb15CTH12Advanced.Models;
using System.Collections.Generic;

namespace LTWeb15CTH12Advanced.ViewModels
{
    public class CourseViewModel
    {
        public string Place { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}