using Microsoft.AspNetCore.Mvc;

namespace GithubExampleCoreProject.ViewComponents.AdminDashboard;

public class _DestinationStatistic : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}