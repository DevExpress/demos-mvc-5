using System.Web.Mvc;
using System.Web.UI;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FilteringController : DemoController {
        public ActionResult FilterBuilder(bool enableTextTab = true) {
            ViewBag.EnableTextTab = enableTextTab;
            return DemoView("FilterBuilder", DepartmentsProvider.GetDepartments());
        }
        public ActionResult FilterBuilderPartial(bool enableTextTab = true) {
            ViewBag.EnableTextTab = enableTextTab;
            return PartialView("FilterBuilderPartial", DepartmentsProvider.GetDepartments());
        }
    }
}
