using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FocusingAndSelectionController: DemoController {
        public ActionResult Selection() {
            return DemoView("Selection", NorthwindDataProvider.GetEmployees());
        }
        public ActionResult SelectionPartial() {
            return PartialView("SelectionPartial", NorthwindDataProvider.GetEmployees());
        }
    }
}
