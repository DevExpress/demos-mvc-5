using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class AreaTypesController : DemoController {
        [HttpGet]
        public ActionResult FullStackedAreaView() {
            ChartAreaFullStckedDemoOptions options = new ChartAreaFullStckedDemoOptions() { Data = DevAV.GetBranchesSales() };
            return DemoView("FullStackedAreaView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FullStackedAreaView([Bind] ChartAreaFullStckedDemoOptions options) {
            options.Data = DevAV.GetBranchesSales();
            return DemoView("FullStackedAreaView", options);
        }
    }
}
