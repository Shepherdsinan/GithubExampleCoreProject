using GithubExampleCoreProject.CQRS.Handlers.DestinationHandlers;
using GithubExampleCoreProject.CQRS.Queries.DestinationQueries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GithubExampleCoreProject.Areas.Admin.Controllers;

[Area("Admin")]
[AllowAnonymous]
public class DestinationCQRSController : Controller
{
    private readonly GetAllDestinationQueryHandler _destinationQueryHandler;
    private readonly GetDestinationByIDQueryHandler _destinationByIDQueryHandler;

    public DestinationCQRSController(GetAllDestinationQueryHandler destinationQueryHandler, GetDestinationByIDQueryHandler destinationByIdQueryHandler)
    {
        _destinationQueryHandler = destinationQueryHandler;
        _destinationByIDQueryHandler = destinationByIdQueryHandler;
    }

    public IActionResult Index()
    {
        var values = _destinationQueryHandler.Handle();
        return View(values);
    }
    
    public IActionResult GetDestination(int id)
    {
        var values = _destinationByIDQueryHandler.Handle(new GetDestinationByIDQuery(id));
        return View(values);
    }
    
}