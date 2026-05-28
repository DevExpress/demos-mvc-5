using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ShapingController : DemoController {
        public ActionResult Sorting() {
            return DemoView("Sorting", DepartmentsProvider.GetDepartments());
        }
        public ActionResult SortingPartial() {
            return PartialView("SortingPartial", DepartmentsProvider.GetDepartments());
        }
    }
}
