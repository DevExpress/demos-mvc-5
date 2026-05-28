using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class RadarTypesController : DemoController {
        [HttpGet]
        public ActionResult RadarRangeAreaView() {
            ChartRadarRangeDemoOptions options = new ChartRadarRangeDemoOptions() {
                Data = WeatherInLondon.GetTemperatureRangeHistory(),
                TextDirection = XtraCharts.RadarAxisXLabelTextDirection.LeftToRight
            };
            return DemoView("RadarRangeAreaView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RadarRangeAreaView([Bind] ChartRadarRangeDemoOptions options) {
            options.Data = WeatherInLondon.GetTemperatureRangeHistory();
            return DemoView("RadarRangeAreaView", options);
        }
    }
}
