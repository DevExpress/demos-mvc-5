using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ExportingController : DemoController {
        public ActionResult Export() {
            return DemoView("Export");
        }
        
        public ActionResult ExportPartial(TreeListExportDemoOptions options) {
            ViewBag.TreeListExportOptions = options;
            return PartialView("ExportPartial", DepartmentsProvider.GetDepartments());
        }
    }
}
