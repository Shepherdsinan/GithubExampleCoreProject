using BusinessLayer.Concrete;
using DataAccessLayer.Entityframework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GithubExampleCoreProject.Areas.Member.Controllers;

[AllowAnonymous]
[Area("Member")]
public class DestinationController : Controller
{
    private DestinationManager _destinationManager = new DestinationManager(new EfDestinationDal());
    public IActionResult Index()
    {
        var values = _destinationManager.TGetList();
        return View(values);
    }
}