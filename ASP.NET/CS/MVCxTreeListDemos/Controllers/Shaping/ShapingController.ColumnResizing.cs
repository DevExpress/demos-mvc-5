using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ShapingController : DemoController {
        public ActionResult ColumnResizing(ColumnResizingDemoOptions options) {
            ViewBag.ResizingOptions = options;
            return DemoView("ColumnResizing", DepartmentsProvider.GetDepartments());
        }
        
        public ActionResult ColumnResizingPartial(ColumnResizingDemoOptions options) {
            ViewBag.ResizingOptions = options;
            return PartialView("ColumnResizingPartial", DepartmentsProvider.GetDepartments());
        }
    }
}
