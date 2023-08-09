using BusinessLayer.Concrete;
using DataAccessLayer.Entityframework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace GithubExampleCoreProject.Controllers;

public class DestinationController : Controller
{
    private DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());

    // GET
    public IActionResult Index()
    {
        var values = destinationManager.TGetList();
        return View(values);
    }

    [HttpGet]
    public IActionResult DestinationDetails(int id)
    {
        ViewBag.i = id;
        var values = destinationManager.TGetByID(id);
        return View(values);
    }
    [HttpPost]
    public IActionResult DestinationDetails(Destination p)
    {
        return View();
    }

}