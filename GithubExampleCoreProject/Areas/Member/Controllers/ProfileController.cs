using Microsoft.AspNetCore.Mvc;

namespace GithubExampleCoreProject.Areas.Member.Controllers;

public class ProfileController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}