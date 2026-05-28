using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class BarTypesController : DemoController {
        [HttpGet]
        public ActionResult FullStackedBarView() {
            ChartBarFullStackedDemoOptions options = new ChartBarFullStackedDemoOptions() { Data = DevAV.GetSalesMixByRegion(), ShowLabels = true };
            return DemoView("FullStackedBarView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FullStackedBarView([Bind]ChartBarFullStackedDemoOptions options) {
            options.Data = DevAV.GetSalesMixByRegion();
            return DemoView("FullStackedBarView", options);
        }
    }
}
