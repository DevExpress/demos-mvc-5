using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SelectionController : DemoController {
        public ActionResult RowSelection() {
            return DemoView("RowSelection", NorthwindDataProvider.GetCustomers());
        }
        public ActionResult RowSelectionPartial() {
            return PartialView("RowSelectionPartial", NorthwindDataProvider.GetCustomers());
        }
    }
}
