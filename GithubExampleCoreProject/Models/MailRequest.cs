using MimeKit;

namespace GithubExampleCoreProject.Models;

public class MailRequest
{
    public string SenderMail { get; set; }
    public string ReceiverMail { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public string Name { get; set; }
}