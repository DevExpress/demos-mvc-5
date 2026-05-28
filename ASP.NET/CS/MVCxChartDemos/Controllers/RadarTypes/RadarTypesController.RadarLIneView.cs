using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class RadarTypesController : DemoController {
        [HttpGet]
        public ActionResult RadarLineView() {
            ChartRadarDemoOptions options = new ChartRadarDemoOptions() { Data = WeatherInLondon.GetTemperatureHistory(), ShowMarkers = true };
            return DemoView("RadarLineView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RadarLineView([Bind] ChartRadarDemoOptions options) {
            options.Data = WeatherInLondon.GetTemperatureHistory();
            return DemoView("RadarLineView", options);
        }
    }
}
