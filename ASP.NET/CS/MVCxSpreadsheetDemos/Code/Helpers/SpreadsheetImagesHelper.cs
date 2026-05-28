using System.Collections.Generic;
using System.IO;
using DevExpress.Spreadsheet;
using DevExpress.XtraSpreadsheet.API.Native.Implementation;

namespace DevExpress.Web.Demos {
    public class SpreadsheetImagesDemoHelper {
        const int StartAddressRowOffset = 4;

        public static void AddImagesToWorksheet(Worksheet worksheet) {
            if(worksheet.Shapes.Count > 0)
                return;
            IList<EmployeeData> employees = EmployeesDataProvider.GetEmployees();
            int employeesCount = employees.Count;
            CreateRequiredRows(worksheet, employeesCount);
            for(var i = 0; i < employeesCount; i++) {
                var rowOffset = StartAddressRowOffset + i;
                EmployeeData employee = employees[i];
                worksheet["C" + rowOffset].Value = string.Format("{0} {1}", employee.FirstName, employee.LastName);
                worksheet["D" + rowOffset].Value = employee.BirthDate;
                worksheet["E" + rowOffset].Value = employee.Country;
                worksheet["F" + rowOffset].Value = employee.City;
                worksheet["G" + rowOffset].Value = employee.Address;
                worksheet["H" + rowOffset].Value = employee.HomePhone;
                MemoryStream photoMemoryStream = new MemoryStream(employee.Photo);
                worksheet.Pictures.AddPicture(new StreamDocumentImageSource(photoMemoryStream), worksheet["B" + rowOffset]);
            }
            worksheet.Workbook.History.Clear();
        }
        static void CreateRequiredRows(Worksheet worksheet, int rowsCount) {
            var sourceStyleRow = worksheet.Rows[StartAddressRowOffset - 1];
            for(var i = 0; i < rowsCount; i++) {
                var rowOffset = StartAddressRowOffset + i;
                if(rowOffset > StartAddressRowOffset)
                    worksheet.Rows[rowOffset - 1].CopyFrom(sourceStyleRow);
            }
        }
    }
}
