using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace GithubExampleCoreProject.ViewComponents.Destination;

public class _GuideDetails : ViewComponent
{
    private readonly IGuideService _guideService;

    public _GuideDetails(IGuideService guideService)
    {
        _guideService = guideService;
    }
    
    public IViewComponentResult Invoke()
    {
        var guide = _guideService.TGetByID(1);
        return View(guide);
    }
}