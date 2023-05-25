using BusinessLayer.Concrete;
using DataAccessLayer.Entityframework;
using Microsoft.AspNetCore.Mvc;

namespace GithubExampleCoreProject.ViewComponents.MemberDashboard;

public class _GuideList : ViewComponent
{
    private GuideManager _guideManager = new GuideManager(new EfGuideDal());

    public IViewComponentResult Invoke()
    {
        var values = _guideManager.TGetList();
        return View(values);
    }
}