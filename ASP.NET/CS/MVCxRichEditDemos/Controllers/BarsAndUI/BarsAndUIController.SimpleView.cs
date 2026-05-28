using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class BarsAndUIController : DemoController {
        public ActionResult SimpleView() {
            return DemoView("SimpleView");
        }
        public ActionResult SimpleViewPartial() {
            return PartialView("SimpleViewPartial");
        }
    }
}
