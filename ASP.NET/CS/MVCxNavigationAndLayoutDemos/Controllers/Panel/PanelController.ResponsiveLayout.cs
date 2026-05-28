using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PanelController : DemoController {
        public ActionResult ResponsiveLayout() {
            return DemoView("ResponsiveLayout");
        }
        public ActionResult ResponsiveLayoutPage() {
            return View("ResponsiveLayoutPage", NorthwindDataProvider.GetEmployeesList());
        }
        public ActionResult ResponsiveLayoutGridPartial(int? employeeID) {
            employeeID = employeeID ?? NorthwindDataProvider.GetFirstEmployeeID();
            return PartialView("ResponsiveLayoutGridPartial", NorthwindDataProvider.GetOrders(employeeID.Value));
        }
    }
}
