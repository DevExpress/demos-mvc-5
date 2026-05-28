using System.Threading;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class LoadingPanelController : DemoController {
        public ActionResult Example() {
            return DemoView("Example", true);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Example(bool displayOverPanel) {
            return DemoView("Example", displayOverPanel);
        }
        public ActionResult ExamplePartial() {
            if(DevExpressHelper.IsCallback)
                // Intentionally pauses server-side processing,
                // to demonstrate the Loading Panel functionality.
                Thread.Sleep(500);
            return PartialView("ExamplePartial");
        }
    }
}
