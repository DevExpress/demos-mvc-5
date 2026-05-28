using System;
using System.Drawing;
using System.Globalization;
using DevExpress.Spreadsheet;

namespace DevExpress.Web.Demos {
    public class CellValueDemoHelper {
        static Worksheet worksheet;

        public static void PrepareWorksheet(Worksheet worksheetToPrepare) {
            worksheet = worksheetToPrepare;
            PrepareTitleRange();
            PrepareHeaderCells();
            InitializeDataCellsValues();
            worksheet.Workbook.Options.Culture = CultureInfo.InvariantCulture;
            worksheet.Workbook.History.Clear();
        }

        static void PrepareTitleRange() {
            worksheet.Cells["B1"].FillColor = Color.LightBlue;
            worksheet.Cells["B1"].Value = "Cell value types";
            var range = worksheet.Range["A1:B1"];
            range.Style = worksheet.Workbook.Styles["Title"];
            range.Merge();
        }
        static void PrepareHeaderCells() {
            var header = worksheet.Range["A2:B2"];
            header[0].Value = "Type";
            header[1].Value = "Value";
            header.ColumnWidthInCharacters = 25;
            header.Style = worksheet.Workbook.Styles["Heading 2"];
        }
        static void InitializeDataCellsValues() {
            // Add data of different types to cells.
            worksheet.Cells["B3"].Value = DateTime.Now;
            worksheet.Cells["B4"].Value = Math.PI;
            worksheet.Cells["B5"].Value = "Have a nice day!";
            worksheet.Cells["B6"].Value = CellValue.ErrorReference;
            worksheet.Cells["B7"].Value = true;
            worksheet.Cells["B8"].Value = float.MaxValue;
            worksheet.Cells["B9"].Value = 'a';
            worksheet.Cells["B10"].Value = Int32.MaxValue;

            worksheet.Cells["A3"].Value = "dateTime";
            worksheet.Cells["A4"].Value = "double";
            worksheet.Cells["A5"].Value = "string";
            worksheet.Cells["A6"].Value = "error constant";
            worksheet.Cells["A7"].Value = "boolean";
            worksheet.Cells["A8"].Value = "float";
            worksheet.Cells["A9"].Value = "char";
            worksheet.Cells["A10"].Value = "int32";
            worksheet.Cells["A13"].Value = "fill range";

            // Fill all cells of the range with 10.
            worksheet.Range["B13:C13"].Value = 10;
        }
    }
}
