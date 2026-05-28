using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class GridLookupController: DemoController {
        public ActionResult AdvancedLookup() {
            return DemoView("AdvancedLookup", NorthwindDataProvider.GetEmployees());
        }
        public ActionResult AdvancedLookupPartial() {
            return PartialView("AdvancedLookupPartial", NorthwindDataProvider.GetEmployees());
        }
    }
}
