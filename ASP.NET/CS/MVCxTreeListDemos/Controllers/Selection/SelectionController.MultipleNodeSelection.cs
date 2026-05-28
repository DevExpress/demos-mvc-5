using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SelectionController : DemoController {
        public ActionResult MultipleNodeSelection(TreeListMultipleSelectionDemoOptions options) {
            ViewBag.Options = options;
            return DemoView("MultipleNodeSelection", options);
        }
        public ActionResult MultipleNodeSelectionPartial(TreeListMultipleSelectionDemoOptions options) {
            ViewBag.Options = options;
            return PartialView("MultipleNodeSelectionPartial", DepartmentsProvider.GetDepartments());
        }
    }
}
