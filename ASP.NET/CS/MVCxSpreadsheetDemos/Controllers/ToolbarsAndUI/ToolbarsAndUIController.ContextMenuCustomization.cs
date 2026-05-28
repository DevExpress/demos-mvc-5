using System.Linq;
using System.Web.Mvc;
using DevExpress.Spreadsheet;

namespace DevExpress.Web.Demos {
    public partial class ToolbarsAndUIController : DemoController {
        public ActionResult ContextMenuCustomization() {
            return DemoView("ContextMenuCustomization");
        }

        public ActionResult ContextMenuCustomizationPartial() {
            return PartialView("ContextMenuCustomizationPartial");
        }

        public string GetDiscountStructure(int rowIndex) {
            Worksheet activeWorksheet = GetOpenedDocumentActiveWorksheet();
            int selectedRowNumber = rowIndex + 1;
            var discountInfoRange = activeWorksheet.Range["J" + selectedRowNumber + ":N" + selectedRowNumber];
            string resultFormat = "{0} to {4} units - {1}, <br /> {2} units or more - {3}";
            string[] cellValues = discountInfoRange.ExistingCells.Select((c, index) => (index % 2 == 0) ? c.Value.ToString() : c.DisplayText).ToArray();
            return string.Format(resultFormat, cellValues);
        }
        protected Worksheet GetOpenedDocumentActiveWorksheet() {
            ASPxSpreadsheet.ASPxSpreadsheet spreadsheet = new ASPxSpreadsheet.ASPxSpreadsheet();
            spreadsheet.Open(ContextMenuCustomizationDemoOptions.PathToDocument);
            return spreadsheet.Document.Worksheets[0];
        }
    }
}
