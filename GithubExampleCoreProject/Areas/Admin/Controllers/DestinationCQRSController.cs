using GithubExampleCoreProject.CQRS.Commands.DestinationCommands;
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
    private readonly CreateDestinationCommandHandler _createDestinationCommandHandler;
    private readonly RemoveDestinationCommandHandler _removeDestinationCommandHandler;
    private readonly UpdateDestinationCommandHandler _updateDestinationCommandHandler;
    public DestinationCQRSController(GetAllDestinationQueryHandler destinationQueryHandler, GetDestinationByIDQueryHandler destinationByIdQueryHandler, CreateDestinationCommandHandler createDestinationCommandHandler, RemoveDestinationCommandHandler removeDestinationCommandHandler, UpdateDestinationCommandHandler updateDestinationCommandHandler)
    {
        _destinationQueryHandler = destinationQueryHandler;
        _destinationByIDQueryHandler = destinationByIdQueryHandler;
        _createDestinationCommandHandler = createDestinationCommandHandler;
        _removeDestinationCommandHandler = removeDestinationCommandHandler;
        _updateDestinationCommandHandler = updateDestinationCommandHandler;
    }

    public IActionResult Index()
    {
        var values = _destinationQueryHandler.Handle();
        return View(values);
    }

    [HttpGet]
    public IActionResult GetDestination(int id)
    {
        var values = _destinationByIDQueryHandler.Handle(new GetDestinationByIDQuery(id));
        return View(values);
    }
    [HttpPost]
    public IActionResult GetDestination(UpdateDestinationCommand command)
    {
        _updateDestinationCommandHandler.Handle(command);
        return RedirectToAction("Index");
    }
    [HttpGet]
    public IActionResult AddDestination()
    {
        return View();
    }
    [HttpPost]
    public IActionResult AddDestination(CreateDestinationCommand command)
    {
        _createDestinationCommandHandler.Handle(command);
        return View("Index");
    }

    public IActionResult DeleteDestination(int id)
    {
        _removeDestinationCommandHandler.Handle(new RemoveDestinationCommand(id));
        return RedirectToAction("Index");
    }
}