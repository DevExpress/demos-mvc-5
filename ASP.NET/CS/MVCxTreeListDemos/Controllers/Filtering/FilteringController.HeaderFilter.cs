using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FilteringController : DemoController {

        public ActionResult HeaderFilter(bool enableCheckedListMode = true) {
            ViewBag.EnableCheckedListMode = enableCheckedListMode;
            return DemoView("HeaderFilter", DepartmentsProvider.GetDepartments());
        }
        public ActionResult HeaderFilterPartial(bool enableCheckedListMode = true) {
            ViewBag.EnableCheckedListMode = enableCheckedListMode;
            return PartialView("HeaderFilterPartial", DepartmentsProvider.GetDepartments());
        }
    }
}
