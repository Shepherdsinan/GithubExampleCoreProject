using BusinessLayer.Abstract;
using OfficeOpenXml;

namespace BusinessLayer.Concrete;

public class ExcelManager : IExcelService
{
    public byte[] ExcelList<T>(List<T> t) where T : class
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        ExcelPackage excelPackage = new ExcelPackage();
        var workSheet = excelPackage.Workbook.Worksheets.Add("Sayfa1");
        workSheet.Cells["A1"].LoadFromCollection(t, true, OfficeOpenXml.Table.TableStyles.Light10);

        return excelPackage.GetAsByteArray();
    }
}