using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class MiscellaneousController : DemoController {
        [HttpGet]
        public ActionResult EmptyPoints() {
            ChartEmptyPointsOptions options = new ChartEmptyPointsOptions() { Data = WeatherInWashington.Data };
            return DemoView("EmptyPoints", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EmptyPoints([Bind] ChartEmptyPointsOptions options) {
            options.Data = WeatherInWashington.Data;
            return DemoView("EmptyPoints", options);
        }
    }
}
