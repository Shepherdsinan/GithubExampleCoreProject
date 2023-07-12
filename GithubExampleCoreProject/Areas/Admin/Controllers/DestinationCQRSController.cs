using GithubExampleCoreProject.CQRS.Handlers.DestinationHandlers;
using Microsoft.AspNetCore.Mvc;

namespace GithubExampleCoreProject.Areas.Admin.Controllers;

public class DestinationCQRSController : Controller
{
    private readonly GetAllDestinationQueryHandler _destinationQueryHandler;

    public DestinationCQRSController(GetAllDestinationQueryHandler destinationQueryHandler)
    {
        _destinationQueryHandler = destinationQueryHandler;
    }

    public IActionResult Index()
    {
        var values = _destinationQueryHandler.Handle();
        return View(values);
    }
}