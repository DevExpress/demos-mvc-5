using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class RadarTypesController : DemoController {
        [HttpGet]
        public ActionResult RadarPointView() {
            ChartRadarDemoOptions options = new ChartRadarDemoOptions() { Data = WeatherInLondon.GetTemperatureHistory() };
            return DemoView("RadarPointView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RadarPointView([Bind] ChartRadarDemoOptions options) {
            options.Data = WeatherInLondon.GetTemperatureHistory();
            return DemoView("RadarPointView", options);
        }
    }
}
