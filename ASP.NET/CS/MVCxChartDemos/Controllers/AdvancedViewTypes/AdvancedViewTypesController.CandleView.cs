using System.Web.Mvc;
using DevExpress.Web.Demos.Charts;

namespace DevExpress.Web.Demos.Charts {
    public partial class AdvancedViewTypesController : DemoController {
        [HttpGet]
        public ActionResult CandleView() {
            ChartCandleDemoOptions options = new ChartCandleDemoOptions() { Data = GoogleStockPricesProvider.GetGoogleStockPrices() };
            return DemoView("CandleView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CandleView([Bind] ChartCandleDemoOptions options) {
            options.Data = GoogleStockPricesProvider.GetGoogleStockPrices();
            return DemoView("CandleView", options);
        }
    }
}
