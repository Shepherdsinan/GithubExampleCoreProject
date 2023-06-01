using BusinessLayer.Abstract;
using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using GithubExampleCoreProject.Models;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;

namespace GithubExampleCoreProject.Controllers;

public class ExcelController : Controller
{
    private readonly IExcelService _excelService;

    public ExcelController(IExcelService excelService)
    {
        _excelService = excelService;
    }

    public IActionResult Index()
    {
        return View();
    }

    public List<DestinationModel> DestinationList()
    {
        List<DestinationModel> destinationModels = new List<DestinationModel>();
        using (var c = new Context())
        {
            destinationModels = c.Destinations.Select(x => new DestinationModel()
            {
                City = x.City,
                DayNight = x.DayNight,
                Price = x.Price,
                Capacity = x.Capacity
            }).ToList();
        }

        return destinationModels;
    }

    public IActionResult StaticExcelReport()
    {

        return File(_excelService.ExcelList(DestinationList()),
            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "YeniExcel.xlsx");
        
        
        
        
        /*ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        ExcelPackage excelPackage = new ExcelPackage();
        var workSheet = excelPackage.Workbook.Worksheets.Add("Sayfa1");
        workSheet.Cells[1, 1].Value = "Rota";
        workSheet.Cells[1, 2].Value = "Rehber";
        workSheet.Cells[1, 3].Value = "Kontenjan";
        
        workSheet.Cells[2, 1].Value = "Gürcistan Batum Turu";
        workSheet.Cells[2, 2].Value = "Kadir Yıldız";
        workSheet.Cells[2, 3].Value = "50";
        
        workSheet.Cells[3, 1].Value = "Sırbıstan - Makedonya Turu";
        workSheet.Cells[3, 2].Value = "Zeynep Öztürk";
        workSheet.Cells[3, 3].Value = "35";

        var bytes = excelPackage.GetAsByteArray();
        return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "dosya1.xlsx");*/
    }

    public IActionResult DestinationExcelReport()
    {
        using (var workbook = new XLWorkbook())
        {
            var workSheet = workbook.Worksheets.Add("Tur Listesi");
            workSheet.Cell(1, 1).Value = "Şehir";
            workSheet.Cell(1, 2).Value = "Konaklama Süresi";
            workSheet.Cell(1, 3).Value = "Fiyat";
            workSheet.Cell(1, 4).Value = "Kapasite";

            int count = 2;
            foreach (var item in DestinationList())
            {
                workSheet.Cell(count, 1).Value = item.City;
                workSheet.Cell(count, 2).Value = item.DayNight;
                workSheet.Cell(count, 3).Value = item.Price;
                workSheet.Cell(count, 4).Value = item.Capacity;
                count++;
            }

            using (var stream = new MemoryStream())
            {
                workbook.SaveAs(stream);
                var content = stream.ToArray();
                return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "YeniListe.xlsx");
            }
        }
    }
}