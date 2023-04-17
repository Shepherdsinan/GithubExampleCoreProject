using BusinessLayer.Concrete;
using DataAccessLayer.Entityframework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace GithubExampleCoreProject.ViewComponents.Default;

public class _PopularDestinations : ViewComponent
{
    private DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
    public IViewComponentResult Invoke()
    {
        var values = destinationManager.TGetList();
        return View(values);
    }
}