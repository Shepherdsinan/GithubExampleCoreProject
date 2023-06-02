using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace GithubExampleCoreProject.Controllers;
[Area("Admin")]
public class ContactUsController : Controller
{
    private readonly IContactUsService _contactUsService;

    public ContactUsController(IContactUsService contactUsService)
    {
        _contactUsService = contactUsService;
    }

    public IActionResult Index()
    {
        var values = _contactUsService.TGetlistContactUsByTrue();
        return View(values);
    }
}