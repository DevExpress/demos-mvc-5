using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class PointAndLineTypesController : DemoController {
        [HttpGet]
        public ActionResult StackedLine3DView() {
            Chart3DDemoOptions options = new Chart3DDemoOptions() { Data = DevAV.GetSalesByLast10Years() };
            return DemoView("StackedLine3DView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult StackedLine3DView([Bind] Chart3DDemoOptions options) {
            options.Data = DevAV.GetSalesByLast10Years();
            return DemoView("StackedLine3DView", options);
        }
    }
}
