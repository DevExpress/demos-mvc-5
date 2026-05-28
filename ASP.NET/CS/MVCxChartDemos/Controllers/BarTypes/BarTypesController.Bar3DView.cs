using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class BarTypesController : DemoController {
        [HttpGet]
        public ActionResult Bar3DView() {
            ChartBar3DDemoOptions options = new ChartBar3DDemoOptions() { Data = DevAV.GetSales(), Transparency = 0 };
            return DemoView("Bar3DView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Bar3DView([Bind]ChartBar3DDemoOptions options) {
            options.Data = DevAV.GetSales();
            return DemoView("Bar3DView", options);
        }
    }
}

