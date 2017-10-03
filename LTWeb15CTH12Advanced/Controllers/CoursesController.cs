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

        // anh nguyen 999 Create Course
        // anh nguyen 999 conflict
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