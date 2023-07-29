namespace DTOLayer.DTOs.MailDTOs;

public class MailRequestDTOs
{
    public string? SenderMail { get; set; }
    public string? ReceiverMail { get; set; }
    public string? Subject { get; set; }
    public string? Body { get; set; }
    public string? Name { get; set; }
}