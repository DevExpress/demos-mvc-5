using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FilteringController : DemoController {
        public ActionResult SearchPanel() {
            return DemoView("SearchPanel", DepartmentsProvider.GetDepartments());
        }
        public ActionResult SearchPanelPartial() {
            return PartialView("SearchPanelPartial", DepartmentsProvider.GetDepartments());
        }
    }
}
