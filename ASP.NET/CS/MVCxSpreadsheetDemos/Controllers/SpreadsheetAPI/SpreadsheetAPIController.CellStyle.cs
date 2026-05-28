using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SpreadsheetAPIController : DemoController {
        public ActionResult CellStyle() {
            return DemoView("CellStyle");
        }
        public ActionResult CellStylePartial() {
            return PartialView("CellStylePartial");
        }
    }
}
