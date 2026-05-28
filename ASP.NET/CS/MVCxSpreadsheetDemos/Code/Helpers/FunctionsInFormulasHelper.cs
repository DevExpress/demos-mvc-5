using DevExpress.Spreadsheet;

namespace DevExpress.Web.Demos {
    public class FunctionsInFormulasDemoHelper {
        static Worksheet worksheet;

        public static void PrepareWorksheet(Worksheet worksheetToPrepare) {
            worksheet = worksheetToPrepare;
            PrepareHeaderCells();
            ProvideStaticDataForFunctions();
            FillCellsWithFormulas();
            FormatCellsValues();
            worksheet.Range["B1:C1"].AutoFitColumns();
            worksheet.Workbook.History.Clear();
        }

        static void PrepareHeaderCells() {
            var header = worksheet.Range["A1:C1"];
            header[0].Value = "Data:";
            header[1].Value = "Formula text:";
            header[2].Value = "Formula result:";
            header.Style = worksheet.Workbook.Styles["Heading 2"];
            worksheet["A1:A7"].Alignment.Indent = 1;
        }
        static void ProvideStaticDataForFunctions() {
            worksheet.Cells["A2"].Value = 15;
            worksheet.Range["A3:A5"].Value = 3;
            worksheet.Cells["A6"].Value = 20;
            worksheet.Cells["A7"].Value = 15.12345;
        }
        static void FillCellsWithFormulas() {
            // If a number in cell A2 is less than 10, the formula returns "Normal" 
            // and this text is displayed in cell B2. Otherwise, cell B2 displays "Excess".
            worksheet.Cells["C2"].Formula = @"= IF(A2<10, ""Normal"", ""Excess"")";

            // Calculate an average value of cell values of the "A2:A7" range.
            worksheet.Cells["C3"].Formula = "=AVERAGE(A2:A7)";

            // Add values contained in cells A3 through A5, then add the value contained in cell A6, 
            // and then add 100 to that result.
            worksheet.Cells["C4"].Formula = "=SUM(A3:A5,A6,100)";

            // Use a nested function in a formula. 
            // Round the sum of the values contained in cells A6 and A7 to two decimal places.
            worksheet.Cells["C5"].Formula = "=ROUND(SUM(A6,A7),2)";

            // Add the current date to cell B6.
            worksheet.Cells["C6"].Formula = "= Today()";
            worksheet.Cells["C6"].NumberFormat = "m/d/yy";

            // Convert the specified text to uppercase.
            worksheet.Cells["C7"].Formula = @"=UPPER(""formula"")";
        }
        static void FormatCellsValues() {
            var rangeWithFormulas = worksheet.Range["C2:C7"];
            var rangeWithFormulaDescription = worksheet.Range["B2:B7"];

            for(int index = rangeWithFormulas.RowCount - 1; index >= 0; index--) {
                rangeWithFormulaDescription[index].Value = "'" + rangeWithFormulas[index].Formula;
            }
        }
    }
}
