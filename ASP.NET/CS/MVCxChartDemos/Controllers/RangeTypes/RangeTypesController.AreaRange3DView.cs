using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class RangeTypesController : DemoController {
        [HttpGet]
        public ActionResult AreaRange3DView() {
            ChartRange3DDemoOptions options = new ChartRange3DDemoOptions() { Data = SourceOfEnergy.GetOkWtiPrices() };
            return DemoView("AreaRange3DView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AreaRange3DView([Bind] ChartRange3DDemoOptions options) {
            options.Data = SourceOfEnergy.GetOkWtiPrices();
            return DemoView("AreaRange3DView", options);
        }
    }
}
