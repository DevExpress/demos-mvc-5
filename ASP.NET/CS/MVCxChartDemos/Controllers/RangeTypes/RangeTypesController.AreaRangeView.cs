using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class RangeTypesController : DemoController {
        [HttpGet]
        public ActionResult AreaRangeView() {
            ChartRangeDemoOptions options = new ChartRangeDemoOptions();
            options.ShowMarkers = false;
            options.ShowMarkers2 = false;
            options.Data = SourceOfEnergy.GetEuropeBrentPrices();
            return DemoView("AreaRangeView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AreaRangeView([Bind] ChartRangeDemoOptions options) {
            options.Data = SourceOfEnergy.GetEuropeBrentPrices();
            return DemoView("AreaRangeView", options);
        }
    }
}
