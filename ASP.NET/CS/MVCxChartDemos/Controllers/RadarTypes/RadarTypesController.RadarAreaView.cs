using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class RadarTypesController : DemoController {
        [HttpGet]
        public ActionResult RadarAreaView() {
            ChartRadarDemoOptions options = new ChartRadarDemoOptions() { Data = WeatherInLondon.GetTemperatureHistory() };
            return DemoView("RadarAreaView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RadarAreaView([Bind] ChartRadarDemoOptions options) {
            options.Data = WeatherInLondon.GetTemperatureHistory();
            return DemoView("RadarAreaView", options);
        }
    }
}
