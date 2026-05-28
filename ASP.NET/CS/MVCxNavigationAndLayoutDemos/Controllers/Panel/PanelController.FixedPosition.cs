using System.Web.Mvc;
using System.Web.UI;

namespace DevExpress.Web.Demos {
    public partial class PanelController : DemoController {
        public ActionResult FixedPosition() {
            return DemoView("FixedPosition");
        }
        public ActionResult FixedPositionPage() {
            return View();
        }
    }
}
