using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Xml.Serialization;
using DevExpress.Spreadsheet;
using DevExpress.Utils;

namespace DevExpress.Web.Demos {
    public class CustomDataMergingDemoHelper {
        const int StartRowIndex = 10,
              MaxReportRowsCount = 15;

        public static void PerformDataMerging(Worksheet worksheet) {
            Worksheet = worksheet;
            var expenses = LoadExpensesReportData();
            FillGeneralReportInfo(expenses.Info);
            FillReport(expenses.Expenses);
            Worksheet.ActiveView.ShowGridlines = false;
            Worksheet.Workbook.History.Clear();
        }

        static Worksheet Worksheet { get; set; }
        static ExpensesReport LoadExpensesReportData() {
            using(Stream stream = File.OpenRead(HttpContext.Current.Server.MapPath("~/App_Data/Expenses.xml"))) {
                return SafeXml.Deserialize<ExpensesReport>(stream);
            }
        }
        static void FillGeneralReportInfo(ExpensesInfo info) {
            Worksheet["D2"].Value = info.Purpose;
            Worksheet["D3"].Value = info.StatementNumber;

            Worksheet["C7"].Value = info.EmployeeName;
            Worksheet["C8"].Value = info.EmployeeDepartment;
            Worksheet["G7"].Value = info.EmployeePosition;
            Worksheet["G8"].Value = info.Manager;
            Worksheet["K7"].Value = info.SSN;
            Worksheet["K8"].Value = info.EmployeeID;
        }
        static void FillReport(List<Expense> report) {
            int reportCount = Math.Min(report.Count, MaxReportRowsCount);
            for(int i = 0; i < reportCount; i++) {
                Expense expense = report[i];
                int rowOffset = StartRowIndex + i + 1;
                Worksheet["B" + rowOffset].Value = expense.CreationDate;
                Worksheet["C" + rowOffset].Value = expense.Account;
                Worksheet["D" + rowOffset].Value = expense.Description;
                Worksheet["F" + rowOffset].Value = expense.Hotel;
                Worksheet["H" + rowOffset].Value = expense.Transport;
                Worksheet["I" + rowOffset].Value = expense.Fuel;
                Worksheet["J" + rowOffset].Value = expense.Meals;
                Worksheet["L" + rowOffset].Value = expense.Phone;
                Worksheet["M" + rowOffset].Value = expense.Entertainment;
                Worksheet["N" + rowOffset].Value = expense.Misc;
            }
        }
    }
}
