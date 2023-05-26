using Microsoft.AspNetCore.Mvc;

namespace GithubExampleCoreProject.ViewComponents.AdminDashboard;

public class _DashboardBanner : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}