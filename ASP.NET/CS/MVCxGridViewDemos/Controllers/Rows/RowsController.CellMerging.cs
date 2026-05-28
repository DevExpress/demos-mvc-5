using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class RowsController: DemoController {
        public ActionResult CellMerging() {
            return DemoView("CellMerging", NorthwindDataProvider.GetCustomers());
        }
        public ActionResult CellMergingPartial() {
            return PartialView("CellMergingPartial", NorthwindDataProvider.GetCustomers());
        }
    }
}
