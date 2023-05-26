using Microsoft.AspNetCore.Mvc;

namespace GithubExampleCoreProject.ViewComponents.AdminDashboard;

public class _TotalRevenue : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}