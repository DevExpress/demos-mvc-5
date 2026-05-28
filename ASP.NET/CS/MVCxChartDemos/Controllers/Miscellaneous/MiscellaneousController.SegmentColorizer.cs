using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class MiscellaneousController : DemoController {
        [HttpGet]
        public ActionResult SegmentColorizer() {
            ChartSegmentColorizerOptions options = new ChartSegmentColorizerOptions() {
                Data = XMLUtils.LoadDataTableFromXml("CityWeather.xml", "CityWeather"),
                SeriesView = XtraCharts.ViewType.Line,
                SegmentColorizer = "Range Segment Colorizer"
            };
            return DemoView("SegmentColorizer", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SegmentColorizer([Bind]ChartSegmentColorizerOptions options) {
            options.Data = XMLUtils.LoadDataTableFromXml("CityWeather.xml", "CityWeather");
            return DemoView("SegmentColorizer", options);
        }
    }
}
