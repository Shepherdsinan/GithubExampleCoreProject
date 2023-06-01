

using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;

namespace GithubExampleCoreProject.Controllers;

public class PdfReportController : Controller
{
    
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult StaticPdfReport()
    {
        string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreport/" + "dosya1.pdf");
        var stream = new FileStream(path, FileMode.Create);

        Document document = new Document(PageSize.A4);
        PdfWriter.GetInstance(document, stream);
        
        document.Open();

        Paragraph paragraph = new Paragraph("Traversal Rezervasyon Pdf Raporu");
        document.Add(paragraph);
        document.Close();
        return File("/pdfreports/dosya1.pdf", "application/pdf", "dosya1.pdf");
    }

    public IActionResult StaticCustomerReport()
    {
        string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreport/" + "dosya1.pdf");
        var stream = new FileStream(path, FileMode.Create);

        Document document = new Document(PageSize.A4);
        PdfWriter.GetInstance(document, stream);
        
        document.Open();
        PdfPTable pdfPTable = new PdfPTable(3);
        pdfPTable.AddCell(new Phrase("Müşteri Adı"));
        pdfPTable.AddCell(new Phrase("Müşteri Soyadı"));
        pdfPTable.AddCell(new Phrase("Müşteri TC Kimlik"));
        
        pdfPTable.AddCell(new Phrase("Eylül"));
        pdfPTable.AddCell(new Phrase("Güzel"));
        pdfPTable.AddCell(new Phrase("213123123123"));
        
        pdfPTable.AddCell(new Phrase("Kemal"));
        pdfPTable.AddCell(new Phrase("Usta"));
        pdfPTable.AddCell(new Phrase("342341231231"));
        
        pdfPTable.AddCell(new Phrase("Berat"));
        pdfPTable.AddCell(new Phrase("Kar"));
        pdfPTable.AddCell(new Phrase("332423423421"));
        document.Add(pdfPTable);
        document.Close();
        return File("/pdfreports/dosya2.pdf", "application/pdf", "dosya2.pdf");
    }
}