using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class BarTypesController : DemoController {
        [HttpGet]
        public ActionResult BarView() {
            ChartBarDemoOptions options = new ChartBarDemoOptions() { Data = DevAV.GetSales(), ShowLabels = true };
            return DemoView("BarView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BarView([Bind] ChartBarDemoOptions options) {
            options.Data = DevAV.GetSales();
            return DemoView("BarView", options);
        }

        public ActionResult BarPartial(ChartBarDemoOptions options) {
            options.Data = DevAV.GetSales();
            return PartialView("BarViewPartial", options);
        }
    }
}

