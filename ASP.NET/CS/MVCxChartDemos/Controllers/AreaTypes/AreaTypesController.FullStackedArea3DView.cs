using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class AreaTypesController : DemoController {
        [HttpGet]
        public ActionResult FullStackedArea3DView() {
            ChartAreaFullStcked3DDemoOptions options = new ChartAreaFullStcked3DDemoOptions() { Data = DevAV.GetBranchesSales() };
            return DemoView("FullStackedArea3DView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FullStackedArea3DView([Bind] ChartAreaFullStcked3DDemoOptions options) {
            options.Data = DevAV.GetBranchesSales();
            return DemoView("FullStackedArea3DView", options);
        }
    }
}
