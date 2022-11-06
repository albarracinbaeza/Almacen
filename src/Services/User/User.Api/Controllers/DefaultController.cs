using Microsoft.AspNetCore.Mvc;

namespace User.Api.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
