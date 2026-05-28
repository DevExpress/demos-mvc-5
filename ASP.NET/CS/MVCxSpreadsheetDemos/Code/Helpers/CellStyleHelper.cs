using System.Drawing;
using DevExpress.Spreadsheet;

namespace DevExpress.Web.Demos {
    public class CellStyleDemoHelper {
        static Worksheet worksheet;

        public static void PrepareWorksheet(Worksheet worksheetToPrepare) {
            worksheet = worksheetToPrepare;
            Cell cell = worksheet.Cells["B1"];
            cell.Value = "Test";
            cell.Select();
            FormatCell(cell);
            FormatBorders();
            worksheet.Workbook.History.Clear();
        }

        static void FormatCell(Cell cell) {
            // Specify font settings (font name, color, size and style).
            cell.Font.Name = "MV Boli";
            cell.Font.Color = Color.Blue;
            cell.Font.Size = 14;
            cell.Font.FontStyle = DevExpress.Spreadsheet.SpreadsheetFontStyle.Bold;

            // Specify cell background color.
            cell.Fill.BackgroundColor = Color.LightSkyBlue;

            // Specify text alignment in the cell. 
            cell.Alignment.Vertical = SpreadsheetVerticalAlignment.Center;
            cell.Alignment.Horizontal = DevExpress.Spreadsheet.SpreadsheetHorizontalAlignment.Center;
        }
        static void FormatBorders() {
            // Set all borders for the range of cells in one step.
            var rangeB8F13 = worksheet.Range["B8:F13"];
            rangeB8F13.Borders.SetAllBorders(Color.Green, BorderLineStyle.Double);

            // Set all inside and outside borders separately for the range of cells.
            var rangeI6L10 = worksheet.Range["I6:L10"];
            rangeI6L10.SetInsideBorders(Color.SkyBlue, BorderLineStyle.MediumDashed);
            rangeI6L10.Borders.SetOutsideBorders(Color.DeepSkyBlue, BorderLineStyle.Medium);

            // Set all horizontal and vertical borders separately for the range of cells.
            var rangeC3E5 = worksheet.Range["C3:E5"];
            Formatting rangeD21F23Formatting = rangeC3E5.BeginUpdateFormatting();
            Borders rangeD21F23Borders = rangeD21F23Formatting.Borders;
            rangeD21F23Borders.InsideHorizontalBorders.LineStyle = BorderLineStyle.MediumDashDot;
            rangeD21F23Borders.InsideHorizontalBorders.Color = Color.DarkBlue;
            rangeD21F23Borders.InsideVerticalBorders.LineStyle = BorderLineStyle.MediumDashDotDot;
            rangeD21F23Borders.InsideVerticalBorders.Color = Color.Blue;
            rangeC3E5.EndUpdateFormatting(rangeD21F23Formatting);
        }
    }
}
