using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AccessibilityController : DemoController {
        public ActionResult Compliance() {
            return DemoView("Compliance", DepartmentsProvider.GetDepartments());
        }

        public ActionResult CompliancePartial() {
            return PartialView("CompliancePartial", DepartmentsProvider.GetDepartments());
        }
    }
}
