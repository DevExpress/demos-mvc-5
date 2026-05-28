using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class PointAndLineTypesController : DemoController {
        [HttpGet]
        public ActionResult FullStackedLineView() {
            ChartLineFullStckedDemoOptions options = new ChartLineFullStckedDemoOptions() { Data = DevAV.GetBranchesSales() };
            return DemoView("FullStackedLineView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FullStackedLineView([Bind] ChartLineFullStckedDemoOptions options) {
            options.Data = DevAV.GetBranchesSales();
            return DemoView("FullStackedLineView", options);
        }
    }
}
