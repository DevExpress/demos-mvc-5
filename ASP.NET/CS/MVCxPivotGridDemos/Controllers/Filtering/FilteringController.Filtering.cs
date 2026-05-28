using DevExpress.Web.Demos.Mvc;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FilteringController : DemoController {
        public ActionResult Filtering() {
            return DemoView("Filtering");
        }

        public ActionResult FilteringPartial() {
            return PartialView("FilteringPartial", NorthwindDataProvider.GetCustomerReports());
        }
    }
}
