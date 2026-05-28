using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class AreaTypesController : DemoController {
        [HttpGet]
        public ActionResult SplineFullStackedAreaView() {
            ChartAreaFullStckedDemoOptions options = new ChartAreaFullStckedDemoOptions() { Data = DevAV.GetBranchesSales() };
            return DemoView("SplineFullStackedAreaView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SplineFullStackedAreaView([Bind] ChartAreaFullStckedDemoOptions options) {
            options.Data = DevAV.GetBranchesSales();
            return DemoView("SplineFullStackedAreaView", options);
        }
    }
}
