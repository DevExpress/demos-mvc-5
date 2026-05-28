using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class TreeViewController: DemoController {
        public ActionResult NodeTextWrapping() {
            return DemoView("NodeTextWrapping", true);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NodeTextWrapping([Bind]bool? chEnableNodeTextWrapping) {
            return DemoView("NodeTextWrapping", chEnableNodeTextWrapping);
        }
        public ActionResult NodeTextWrappingPartial() {
            return PartialView("VirtualModePartial");
        }
    }
}
