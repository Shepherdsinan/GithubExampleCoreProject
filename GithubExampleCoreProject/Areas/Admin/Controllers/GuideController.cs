using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NToastNotify;

namespace GithubExampleCoreProject.Areas.Admin.Controllers;

[Area("Admin")]
[Route("Admin/[controller]/[action]/{id?}")]
public class GuideController : Controller
{
    private readonly IGuideService _guideService;
    private readonly IToastNotification _toastNotification;


    public GuideController(IGuideService guideService, IToastNotification toastNotification)
    {
        _guideService = guideService;
        _toastNotification = toastNotification;
    }

    public IActionResult Index()
    {
        var values = _guideService.TGetList();
        return View(values);
    }


    [HttpGet]
    public IActionResult AddGuide()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddGuide(Guide guide)
    {
        GuideValidator validator = new GuideValidator();
        ValidationResult result = validator.Validate(guide);
        if (result.IsValid)
        {
            _guideService.TAdd(guide);
            _toastNotification.AddSuccessToastMessage("Rehber Ekleme Başarılı");
            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }
        else
        {
            foreach (var item in result.Errors)
            {
                ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            }

            return View();
        }
    }

    [HttpGet]
    public IActionResult EditGuide(int id)
    {
        var values = _guideService.TGetByID(id);
        return View(values);
    }

    [HttpPost]
    public IActionResult EditGuide(Guide guide)
    {
        _guideService.TUpdate(guide);
        return RedirectToAction("Index", "Guide", new { area = "Admin" });
    }
    public IActionResult DeleteGuide(int id)
    {
        var values = _guideService.TGetByID(id);
        _guideService.TDelete(values);
        _toastNotification.AddSuccessToastMessage("Silme İşlemi başarılı");
        return RedirectToAction("Index");
    }
    public IActionResult ChangeToGuideStat(int id)
    {
        _guideService.ChangeGuideStat(id);
        _toastNotification.AddInfoToastMessage("Rehber Durumu Değiştirildi");
        return RedirectToAction("Index", "Guide", new { area = "Admin" });
    }
}