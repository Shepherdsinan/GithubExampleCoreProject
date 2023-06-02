using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using GithubExampleCoreProject.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace GithubExampleCoreProject.Areas.Admin.Controllers;
[Area("Admin")]
public class AnnouncementController : Controller
{
    private readonly IAnnouncementService _announcementService;

    public AnnouncementController(IAnnouncementService announcementService)
    {
        _announcementService = announcementService;
    }

    public IActionResult Index()
    {
        List<Announcement> announcements = _announcementService.TGetList();
        List<AnnouncementListViewModel> model = new List<AnnouncementListViewModel>();
        foreach (var item in announcements)
        {
            AnnouncementListViewModel announcementListViewModel = new AnnouncementListViewModel();
            announcementListViewModel.ID = item.AnnouncementId;
            announcementListViewModel.Title = item.Title;
            announcementListViewModel.Content = item.Content;
            
            model.Add(announcementListViewModel);
        }
        return View(model);
    }

    [HttpGet]
    public IActionResult AddAnnouncement()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddAnnouncement(int id)
    {
        return View();
    }
}