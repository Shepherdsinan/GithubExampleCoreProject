using BusinessLayer.Concrete;
using DataAccessLayer.Entityframework;
using Microsoft.AspNetCore.Mvc;

namespace GithubExampleCoreProject.ViewComponents.Default;

public class _Feature : ViewComponent
{
    private FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
    public IViewComponentResult Invoke()
    {
       // var values = featureManager.TGetList();
       //ViewBag.image1 = featureManager.TGetByID();
        return View();
    }

}