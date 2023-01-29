using Microsoft.AspNetCore.Mvc;

namespace BlazorApp.Data
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
