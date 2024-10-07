using System;
using System.IO;
using OfficeOpenXml;

namespace ExcelProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Excel package
            var fileInfo = new FileInfo("SampleExcel.xlsx");
            using (var package = new ExcelPackage(fileInfo))
            {
                // Add a new worksheet to the empty workbook
                var worksheet = package.Workbook.Worksheets.Add("Sheet1");

                // Add some sample data
                worksheet.Cells[1, 1].Value = "Hello, World!";
                worksheet.Cells[2, 1].Value = "This is an Excel file created with EPPlus.";

                // Save the Excel file
                package.Save();
            }

            Console.WriteLine("Excel file created successfully!");
        }
    }
}
