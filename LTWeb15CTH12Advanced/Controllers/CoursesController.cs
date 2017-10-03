using LTWeb15CTH12Advanced.Models;
using LTWeb15CTH12Advanced.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace LTWeb15CTH12Advanced.Controllers
{
    public class CoursesController : Controller
    {
        private ApplicationDbContext dbContext;

        public CoursesController()
        {
            dbContext = new ApplicationDbContext();
        }
        [Authorize(Roles = "GiangVien")]
        // Create Course
        // anh nguyen 999 Create Course
        // anh nguyen 999 conflict
        // Create anh nguyen 888 Course
        // Add new anh nguyen 888
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel()
            {
                Categories = dbContext.Categories.ToList()
            };
            return View(viewModel);
        }
    }
}