using Microsoft.AspNetCore.Mvc;

namespace Leave_Management_System.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {

            var data = new Models.TestViewModel
            {
                Name = "Tinotenda",
                DateOfBirth = new DateTime(1990, 1, 1)

            };
            return View(data);
        }
    }
}
