using Microsoft.AspNetCore.Mvc;

namespace GithubExampleCoreProject.Areas.Member.Controllers;

public class MessageController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}