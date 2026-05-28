using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class AdvancedViewTypesController : DemoController {
        [HttpGet]
        public ActionResult StockView() {
            ChartStockDemoOptions options = new ChartStockDemoOptions() {
                Data = GoogleStockPricesProvider.GetGoogleStockPrices()
            };
            return DemoView("StockView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult StockView([Bind] ChartStockDemoOptions options) {
            options.Data = GoogleStockPricesProvider.GetGoogleStockPrices();
            return DemoView("StockView", options);
        }
    }
}
