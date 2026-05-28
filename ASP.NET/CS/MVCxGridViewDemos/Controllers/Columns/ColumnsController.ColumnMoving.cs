using System.Web.Mvc;
using System.Threading;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ColumnsController: DemoController {
        public ActionResult ColumnMoving(ColumnMovingDemoOptions options) {
            return DemoView("ColumnMoving", options);
        }
        public ActionResult ColumnMovingPartial(ColumnMovingDemoOptions options) {
            ViewBag.ColumnMovingOptions = options;
            Thread.Sleep(1500); // Extend the callback delay for demonstration purposes
            return PartialView("ColumnMovingPartial", NorthwindDataProvider.GetProducts());
        }
    }
}
