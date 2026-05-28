using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class BarsAndUIController : DemoController {
        public ActionResult CustomToolbar() {
            return DemoView("CustomToolbar");
        }
        public ActionResult CustomToolbarPartial() {
            return PartialView("CustomToolbarPartial");
        }
    }
}
