
using GithubExampleCoreProject.Models;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace GithubExampleCoreProject.Areas.Admin.Controllers;
[Area("Admin")]
public class MailController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(MailRequest mailRequest)
    {
        MimeMessage mimeMessage = new MimeMessage();
        MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin","example@gmail.com");
        mimeMessage.From.Add(mailboxAddressFrom);
        MailboxAddress mailboxAddressTo = new MailboxAddress("User", mailRequest.ReceiverMail);
        mimeMessage.To.Add(mailboxAddressTo);
        var bodybuilder = new BodyBuilder();
        bodybuilder.TextBody = mailRequest.Body;
        mimeMessage.Body = bodybuilder.ToMessageBody();
        mimeMessage.Subject = mailRequest.Subject;
        SmtpClient client = new SmtpClient();
        client.Connect("smtp.gmail.com",587,false);
        client.Authenticate("example@gmail.com","123456");
        client.Send(mimeMessage);
        client.Disconnect(true);
        return View();
    }
}