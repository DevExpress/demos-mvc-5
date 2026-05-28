using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class PointAndLineTypesController : DemoController {
        [HttpGet]
        public ActionResult StackedLineView() {
            ChartMarkerDemoOptions options = new ChartMarkerDemoOptions() { Data = DevAV.GetSalesByLast10Years(), ShowLabels = true };
            return DemoView("StackedLineView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult StackedLineView([Bind] ChartMarkerDemoOptions options) {
            options.Data = DevAV.GetSalesByLast10Years();
            return DemoView("StackedLineView", options);
        }
    }
}
