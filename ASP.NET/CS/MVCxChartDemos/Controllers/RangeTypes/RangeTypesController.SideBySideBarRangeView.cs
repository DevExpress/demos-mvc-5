using System.Web.Mvc;
using DevExpress.Web.Demos.Charts;

namespace DevExpress.Web.Demos.Charts {
    public partial class RangeTypesController : DemoController {
        [HttpGet]
        public ActionResult SideBySideBarRangeView() {
            ChartRangeDemoOptions options = new ChartRangeDemoOptions() { Data = SourceOfEnergy.GetOilPrices() };
            return DemoView("SideBySideBarRangeView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SideBySideBarRangeView([Bind] ChartRangeDemoOptions options) {
            options.Data = SourceOfEnergy.GetOilPrices();
            return DemoView("SideBySideBarRangeView", options);
        }
    }
}
