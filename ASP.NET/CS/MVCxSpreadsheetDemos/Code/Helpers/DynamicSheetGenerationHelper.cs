using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using DevExpress.Spreadsheet;

namespace DevExpress.Web.Demos {
    public class DynamicSheetGenerationDemoHelper {
        const int FirstTableRowIndex = 8;
        const string WorksheetName = "Loan Amortization Schedule";

        static LoanAmortizationScheduleParameters Parameters {
            get { return LoanAmortizationScheduleProvider.Parameters; }
        }

        static Worksheet GetWorksheet(IWorkbook document) {
            if(document == null)
                return null;
            if(document.Worksheets.Contains(WorksheetName))
                return document.Worksheets[WorksheetName];
            return document.Worksheets.First();
        }

        public static void PrepareSpreadsheetDocument(IWorkbook document) {
            var worksheet = GetWorksheet(document);
            if(worksheet == null)
                return;

            SetupGeneralSettings(document);

            ClearTableBody(worksheet);
            GenerateCalculationResultsFields(worksheet);
            GenerateTableBody(worksheet);
            ApplyStyleToTableBody(worksheet);

            PrepareColumnAndRows(worksheet);
            GenerateTitle(worksheet);
            GenerateTableHeaders(worksheet);

            document.History.Clear();
        }
        static CultureInfo GetCurrentCulture() {
            return Thread.CurrentThread.CurrentCulture;
        }
        static char GetCurrentCultureSeparator() {
            return GetCurrentCulture().TextInfo.ListSeparator[0];
        }
        static string GetCurrentCultureCurrencySymbol() {
            return GetCurrentCulture().NumberFormat.CurrencySymbol;
        }
        static string GetSummaryAccountingFormat() {
            string currencySymbol = GetCurrentCultureCurrencySymbol();
#pragma warning disable DX0025 // not a path (and no traversal here)
            return string.Format("\\{0} #,##0.00;\\{0} #,##0.00;\\{0} \" - \"??;@", currencySymbol);
#pragma warning restore DX0025
        }
        static string GetCurrentCultureDateFormat() {
            return Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern;
        }
        static void SetupGeneralSettings(IWorkbook workbook) {
            workbook.Unit = DevExpress.Office.DocumentUnit.Point;
            workbook.Styles.DefaultStyle.Font.Name = "Tahoma";
            workbook.Styles.DefaultStyle.Font.Size = 10;

            var worksheet = GetWorksheet(workbook);
            worksheet.ActiveView.ShowGridlines = false;
            worksheet.DefaultRowHeight = 15;
            worksheet.Name = WorksheetName;
            worksheet.DefinedNames.Clear();

            worksheet.DefinedNames.Add("_xlnm.Print_Titles", "'" + WorksheetName + "'!$11:$11");
            workbook.BeginUpdate();
            try {
                workbook.DefinedNames.Clear();
                workbook.DefinedNames.Add("Loan_Amount", Parameters.LoanAmount.ToString());
                workbook.DefinedNames.Add("Interest_Rate", Parameters.AnnualInterestRate.ToString());
                workbook.DefinedNames.Add("Loan_Years", Parameters.LoanPeriodInYears.ToString());
                workbook.DefinedNames.Add("Number_of_Payments_Per_Year", Parameters.NumberOfPayments.ToString());
                workbook.DefinedNames.Add("Loan_Start", string.Format("=DATEVALUE(\"{0}\")", Parameters.StartDate.ToShortDateString()));
                workbook.DefinedNames.Add("Extra_Payments", Parameters.OptionalExtraPayments.ToString());
                workbook.DefinedNames.Add("Scheduled_payment", "'" + WorksheetName + "'!$E$4");
                workbook.DefinedNames.Add("Scheduled_Number_Payments", "'" + WorksheetName + "'!$E$5");
                workbook.DefinedNames.Add("Interest_Rate_Per_Month", "=Interest_Rate/Number_of_Payments_Per_Year");
                workbook.DefinedNames.Add("Actual_Number_Payments", string.Format("=NPER(Interest_Rate_Per_Month{0} {1}!$E$4+Extra_Payments{0} -Loan_Amount)", GetCurrentCultureSeparator(), "'" + WorksheetName + "'"));
            }
            finally {
                workbook.EndUpdate();
            }
        }
        static void PrepareColumnAndRows(Worksheet worksheet) {
            worksheet.DefaultColumnWidthInCharacters = 9f;

            worksheet.Columns["A"].WidthInCharacters = 3.43;
            worksheet.Columns["B"].WidthInCharacters = 4.00;
            worksheet.Columns["C"].WidthInCharacters = 12.29;
            worksheet.Columns["D"].WidthInCharacters = 15.71;
            worksheet.Columns["E"].WidthInCharacters = 9.71;
            worksheet.Columns["F"].WidthInCharacters = 12.57;
            worksheet.Columns["G"].WidthInCharacters = 13.14;
            worksheet.Columns["H"].WidthInCharacters = 10.71;
            worksheet.Columns["I"].WidthInCharacters = 10.00;
            worksheet.Columns["J"].WidthInCharacters = 13.71;
            worksheet.Columns["K"].WidthInCharacters = 9.71;

            worksheet.Rows["2"].Height = 31;
            worksheet.Rows["8"].Height = 35;
        }
        static void GenerateTitle(Worksheet worksheet) {
            worksheet["B2"].Value = "Loan Amortization Schedule";
            worksheet["B2:K2"].Merge();

            var formattedRange = worksheet["B2:K2"];
            formattedRange.Font.Size = 26;
            formattedRange.Font.Color = Color.FromArgb(0, 176, 80);
            formattedRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
            formattedRange.Alignment.Vertical = SpreadsheetVerticalAlignment.Center;
        }
        static void GenerateCalculationResultsFields(Worksheet worksheet) {
            worksheet["B4:D4"].Merge();
            worksheet["B5:D5"].Merge();
            worksheet["B6:D6"].Merge();
            worksheet["F4:H4"].Merge();
            worksheet["F5:H5"].Merge();

            var formattedRange = worksheet["B4:D8"];
            formattedRange.Alignment.Indent = 1;
            formattedRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Right;
            formattedRange.Font.Size = 10;

            formattedRange = worksheet["E4:E8"];
            formattedRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
            formattedRange.Font.Size = 10;

            formattedRange = worksheet["F4:F5"];
            formattedRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Right;
            formattedRange.Font.Size = 10;

            formattedRange = worksheet["I4:I8"];
            formattedRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
            formattedRange.Font.Size = 10;

            worksheet["B4"].Value = "First scheduled payment:";
            worksheet["B5"].Value = "Scheduled number of payments:";
            worksheet["B6"].Value = "Actual number of payments:";
            worksheet["F4"].Value = "Total early payments:";
            worksheet["F5"].Value = "Total interest:";

            string summaryAccountingFormat = GetSummaryAccountingFormat();
            worksheet["E4"].NumberFormat = summaryAccountingFormat;
            worksheet["I4"].NumberFormat = summaryAccountingFormat;
            worksheet["I5"].NumberFormat = summaryAccountingFormat;

            int actualLastRow = GetActualLastRow(worksheet);
            char formulaSeparator = Thread.CurrentThread.CurrentCulture.TextInfo.ListSeparator[0];
            int currencyPattern = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyPositivePattern;
            worksheet["E4"].Formula = "=PMT(Interest_Rate_Per_Month" + formulaSeparator + "Scheduled_Number_Payments" + formulaSeparator + "-Loan_Amount)";
            worksheet["E5"].FormulaInvariant = "=Loan_Years*Number_of_Payments_Per_Year";
            worksheet["E6"].Formula = "=ROUNDUP(Actual_Number_Payments" + formulaSeparator + "0)";
            worksheet["I4"].FormulaInvariant = "=SUM(F12:F" + actualLastRow + ")";
            worksheet["I5"].FormulaInvariant = "=SUM($I$12:$I$" + actualLastRow + ")";
        }
        static void GenerateTableHeaders(Worksheet worksheet) {
            var formattedRange = worksheet["B8:K8"];
            formattedRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
            formattedRange.Alignment.Vertical = SpreadsheetVerticalAlignment.Center;
            formattedRange.Alignment.WrapText = true;
            formattedRange.Fill.BackgroundColor = Color.FromArgb(166, 166, 166);
            formattedRange.Font.Color = Color.White;
            formattedRange.Font.Size = 10;

            worksheet["B8"].Value = "No.";
            worksheet["C8"].Value = "Payment Date";
            worksheet["D8"].Value = "Beginning Balance";
            worksheet["E8"].Value = "Scheduled Payment";
            worksheet["F8"].Value = "Extra Payment";
            worksheet["G8"].Value = "Total Payment";
            worksheet["H8"].Value = "Principal";
            worksheet["I8"].Value = "Interest";
            worksheet["J8"].Value = "Ending Balance";
            worksheet["K8"].Value = "Cumulative Interest";
        }
        static void GenerateTableBody(Worksheet worksheet) {
            int scheduledNumberOfPayments = (int)Math.Round(worksheet["E5"].Value.NumericValue);
            int actualNumberOfPayments = GetActualNumberOfPayments(worksheet);
            int actualLastRow = GetActualLastRow(worksheet);
            if(scheduledNumberOfPayments == 0)
                return;
            char formulaSeparator = GetCurrentCultureSeparator();
            for(int i = 0; i < actualNumberOfPayments; i++)
                worksheet["B" + (i + FirstTableRowIndex + 1)].Value = i + 1;
            worksheet["C9:C" + actualLastRow].Formula = "=DATE(YEAR(Loan_Start)" + formulaSeparator + "MONTH(Loan_Start)+(B9)*12/Number_of_Payments_Per_Year" + formulaSeparator + "DAY(Loan_Start))";
            worksheet["D9"].FormulaInvariant = "=Loan_Amount";
            if(scheduledNumberOfPayments > 1)
                worksheet["D10:D" + actualLastRow].FormulaInvariant = "=J9";
            worksheet["E9:E" + actualLastRow].Formula = string.Format("=IF(D9>0{0}IF(Scheduled_payment<D9{0} Scheduled_payment{0} D9){0}0)", formulaSeparator);
            worksheet["F9:F" + actualLastRow].Formula = string.Format("=IF(Extra_Payments<>0{0} IF(Scheduled_payment<D9{0} G9-E9{0} 0){0} 0)", formulaSeparator);
            worksheet["G9:G" + actualLastRow].FormulaInvariant = "=H9+I9";
            worksheet["H9:H" + actualLastRow].Formula = string.Format("=IF(J9>0{0}PPMT(Interest_Rate_Per_Month{0}B9{0}Actual_Number_Payments{0}-Loan_Amount){0}D9)", formulaSeparator);
            worksheet["I9:I" + actualLastRow].Formula = string.Format("=IF(D9>0{0}IPMT(Interest_Rate_Per_Month{0}B9{0}Actual_Number_Payments{0}-Loan_Amount){0}0)", formulaSeparator);
            worksheet["J9:J" + actualLastRow].Formula = string.Format("=IF(D9-PPMT(Interest_Rate_Per_Month{0}B9{0}Actual_Number_Payments{0}-Loan_Amount)>0{0}D9-PPMT(Interest_Rate_Per_Month{0}B9{0}Actual_Number_Payments{0}-Loan_Amount){0}0)", formulaSeparator);
            worksheet["K9:K" + actualLastRow].FormulaInvariant = "=SUM($I$9:$I9)";
        }
        static void ApplyStyleToTableBody(Worksheet worksheet) {
            int actualNumberOfPayments = GetActualNumberOfPayments(worksheet);
            int actualLastRow = GetActualLastRow(worksheet);

            CellRange formattedRange;
            for(int i = 1; i < actualNumberOfPayments; i += 2) {
                formattedRange = worksheet.Range.FromLTRB(1, FirstTableRowIndex + i, 10, FirstTableRowIndex + i);
                formattedRange.Fill.BackgroundColor = Color.FromArgb(217, 217, 217);
            }

            formattedRange = worksheet["B8:K" + actualLastRow];
            formattedRange.Borders.InsideVerticalBorders.LineStyle = BorderLineStyle.Thin;
            formattedRange.Borders.InsideVerticalBorders.Color = Color.White;
            formattedRange.Alignment.Vertical = SpreadsheetVerticalAlignment.Center;

            formattedRange = worksheet["B9:C" + actualLastRow];
            formattedRange.RowHeight = 15;
            formattedRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Right;

            worksheet["C8:C" + actualLastRow].NumberFormat = GetCurrentCultureDateFormat();
            string currencySymbol = GetCurrentCultureCurrencySymbol();
            worksheet["D8:K" + actualLastRow].NumberFormat = string.Format("_(\\{0}* #,##0.00_);_(\\{0} (#,##0.00);_(\\{0}* \" - \"??_);_(@_)", currencySymbol);
        }

        static void ClearTableBody(Worksheet worksheet) {
            if(worksheet.Rows.LastUsedIndex < FirstTableRowIndex)
                return;
            var formattedRange = worksheet["B9:K" + (worksheet.Rows.LastUsedIndex + 1)];
            formattedRange.ClearFormats();
            worksheet["B9:K" + (worksheet.Rows.LastUsedIndex + 1)].Value = CellValue.Empty;
        }

        static int GetActualLastRow(Worksheet worksheet) {
            return FirstTableRowIndex + GetActualNumberOfPayments(worksheet);
        }
        static int GetActualNumberOfPayments(Worksheet worksheet) {
            return (int)Math.Round(worksheet["E6"].Value.NumericValue);
        }
    }
}
