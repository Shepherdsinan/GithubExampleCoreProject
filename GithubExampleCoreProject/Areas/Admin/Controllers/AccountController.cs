using BusinessLayer.Abstract.AbstractUow;
using EntityLayer.Concrete;
using GithubExampleCoreProject.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace GithubExampleCoreProject.Areas.Admin.Controllers;

[Area("Admin")]
public class AccountController : Controller
{
    private readonly IAccountService _accountService;

    public AccountController(IAccountService accountService)
    {
        _accountService = accountService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(AccountViewModel accountViewModel)
    {
        var senderValues = _accountService.TGetById(accountViewModel.SenderId);
        var receiverValues = _accountService.TGetById(accountViewModel.ReceiverId);
        senderValues.Balance -= accountViewModel.Amount;
        receiverValues.Balance += accountViewModel.Amount;

        List<Account> modifiedAccounts = new List<Account>()
        {
            senderValues,
            receiverValues
        };
        _accountService.TMultiUpdate(modifiedAccounts);
        return View();
    }
}