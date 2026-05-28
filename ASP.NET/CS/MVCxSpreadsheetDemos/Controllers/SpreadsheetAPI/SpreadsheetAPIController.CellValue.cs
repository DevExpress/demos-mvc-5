using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SpreadsheetAPIController : DemoController {
        public ActionResult CellValue() {
            return DemoView("CellValue");
        }
        public ActionResult CellValuePartial() {
            return PartialView("CellValuePartial");
        }
    }
}
