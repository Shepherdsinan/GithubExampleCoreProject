using BusinessLayer.Concrete;
using DataAccessLayer.Entityframework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GithubExampleCoreProject.Areas.Member.Controllers;

[Area("Member")]
public class ReservationController : Controller
{
    DestinationManager _destinationManager = new DestinationManager(new EfDestinationDal());

    ReservationManager _reservationManager = new ReservationManager(new EfReservationDal());

    private readonly UserManager<AppUser> _userManager;

    public ReservationController(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<IActionResult> MyCurrentReservation()
    {
        var values = await _userManager.FindByNameAsync(User.Identity.Name);
        var valuelist = _reservationManager.GetListWithReservationByAccepted(values.Id);
        return View(valuelist);
    }

    public async Task<IActionResult> MyOldReservation()
    {
        var values = await _userManager.FindByNameAsync(User.Identity.Name);
        var valuelist = _reservationManager.GetListWithReservationByPrevious(values.Id);
        return View(valuelist);
    }

    public async Task<IActionResult> MyApprovalReservation()
    {
        var values = await _userManager.FindByNameAsync(User.Identity.Name);
        var valuelist = _reservationManager.GetListWithReservationByWaitApproval(values.Id);
        return View(valuelist);
    }

    [HttpGet]
    public IActionResult NewReservation()
    {
        List<SelectListItem> values = (from x in _destinationManager.TGetList()
            select new SelectListItem
            {
                Text = x.City,
                Value = x.DestinationID.ToString()
            }).ToList();
        ViewBag.v = values;
        return View();
    }

    [HttpPost]
    public IActionResult NewReservation(Reservation p)
    {
        p.AppUserId = 6;
        p.Status = "Onay Bekliyor";
        _reservationManager.TAdd(p);
        return RedirectToAction("MyCurrentReservation");
    }
}