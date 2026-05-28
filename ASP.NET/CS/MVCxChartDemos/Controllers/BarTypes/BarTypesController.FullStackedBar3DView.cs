using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class BarTypesController : DemoController {
        [HttpGet]
        public ActionResult FullStackedBar3DView() {
            ChartBarFullStacked3DDemoOptions options = new ChartBarFullStacked3DDemoOptions() { Data = DevAV.GetSalesMixByRegion(), ShowLabels = true };
            return DemoView("FullStackedBar3DView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FullStackedBar3DView([Bind]ChartBarFullStacked3DDemoOptions options) {
            options.Data = DevAV.GetSalesMixByRegion();
            return DemoView("FullStackedBar3DView", options);
        }
    }
}

