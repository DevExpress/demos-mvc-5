using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ColumnsController: DemoController {
        public ActionResult ColumnResizing(ColumnResizingDemoOptions options) {
            return DemoView("ColumnResizing", options);
        }
        public ActionResult ColumnResizingPartial(ColumnResizingDemoOptions options) {
            ViewBag.ColumnResizingOptions = options;
            return PartialView("ColumnResizingPartial", NorthwindDataProvider.GetCustomers());
        }
    }
}
