using Microsoft.AspNetCore.Mvc;

namespace MyBlog.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
