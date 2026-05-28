using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class RangeTypesController : DemoController {
        [HttpGet]
        public ActionResult BarRangeView() {
            ChartDemoOptions options = new ChartDemoOptions() { Data = SourceOfEnergy.GetOilPrices() };
            return DemoView("BarRangeView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BarRangeView([Bind] ChartDemoOptions options) {
            options.Data = SourceOfEnergy.GetOilPrices();
            return DemoView("BarRangeView", options);
        }
    }
}
