using System;
using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class MiscellaneousController : DemoController {

        [HttpGet]
        public ActionResult Histogram() {
            ChartHistogramOptions options = new ChartHistogramOptions() { Data = HistogramDataProvider.GetData().Points, HistogramView = DevExpress.XtraCharts.ViewType.RangeBar, SeriesCount = 3 };
            return DemoView("Histogram", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Histogram([Bind]ChartHistogramOptions options) {
            options.Data = HistogramDataProvider.GetData().Points;
            return DemoView("Histogram", options);
        }

        public ActionResult RefreshAction([Bind]ChartHistogramOptions options) {
            options.Data = HistogramDataProvider.GetNewData().Points;
            return DemoView("Histogram", options);
        }           
    }
}
