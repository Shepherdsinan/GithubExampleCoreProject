using Microsoft.AspNetCore.Mvc;

namespace GithubExampleCoreProject.ViewComponents.MemberDashboard;

public class _PlatformSetting : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }    
}