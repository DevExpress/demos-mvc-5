using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PagingAndScrollingController: DemoController {
        public ActionResult FixedColumns() {
            return DemoView("FixedColumns", NorthwindDataProvider.GetCustomers());
        }
        public ActionResult FixedColumnsPartial() {
            return PartialView("FixedColumnsPartial", NorthwindDataProvider.GetCustomers());
        }
    }
}
