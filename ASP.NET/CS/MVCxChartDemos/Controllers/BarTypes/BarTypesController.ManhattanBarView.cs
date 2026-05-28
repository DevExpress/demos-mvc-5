using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class BarTypesController : DemoController {
        [HttpGet]
        public ActionResult ManhattanBarView() {
            ChartBar3DDemoOptions options = new ChartBar3DDemoOptions() { Data = DevAV.GetSales(), Transparency = 0 };
            return DemoView("ManhattanBarView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ManhattanBarView([Bind]ChartBar3DDemoOptions options) {
            options.Data = DevAV.GetSales();
            return DemoView("ManhattanBarView", options);
        }
    }
}

