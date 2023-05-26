using Microsoft.AspNetCore.Mvc;

namespace GithubExampleCoreProject.ViewComponents.AdminDashboard;

public class _AdminGuideList : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}