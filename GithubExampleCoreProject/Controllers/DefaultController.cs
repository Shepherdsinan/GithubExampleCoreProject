using Microsoft.AspNetCore.Mvc;

namespace GithubExampleCoreProject.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
