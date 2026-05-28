using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FilteringController : DemoController {
        public ActionResult FilterRow() {
            return DemoView("FilterRow", DepartmentsProvider.GetDepartments());
        }

        public ActionResult FilterRowPartial() {
            return PartialView("FilterRowPartial", DepartmentsProvider.GetDepartments());
        }
    }
}
