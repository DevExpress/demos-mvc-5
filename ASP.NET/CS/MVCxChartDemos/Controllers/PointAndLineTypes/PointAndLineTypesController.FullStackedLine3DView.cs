using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class PointAndLineTypesController : DemoController {
        [HttpGet]           
        public ActionResult FullStackedLine3DView() {
            ChartBarFullStacked3DDemoOptions options = new ChartBarFullStacked3DDemoOptions() { Data = DevAV.GetBranchesSales() };
            return DemoView("FullStackedLine3DView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FullStackedLine3DView([Bind] ChartBarFullStacked3DDemoOptions options) {
            options.Data = DevAV.GetBranchesSales();
            return DemoView("FullStackedLine3DView", options);
        }
    }
}
