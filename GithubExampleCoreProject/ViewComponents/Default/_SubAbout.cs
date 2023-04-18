using BusinessLayer.Concrete;
using DataAccessLayer.Entityframework;
using Microsoft.AspNetCore.Mvc;

namespace GithubExampleCoreProject.ViewComponents.Default;

public class _SubAbout : ViewComponent
{
    SubAboutManager subAboutManager = new SubAboutManager(new EfSubAboutDal());
    public IViewComponentResult Invoke()
    {
        var values = subAboutManager.TGetList();
        return View(values);
    }
}