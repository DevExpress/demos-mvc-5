using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class UICustomizationController : DemoController {
        public ActionResult Columns() {
            return DemoView("Columns");
        }        
        public ActionResult ColumnsPartial() {
            return PartialView("ColumnsPartial");
        }
    }
}
