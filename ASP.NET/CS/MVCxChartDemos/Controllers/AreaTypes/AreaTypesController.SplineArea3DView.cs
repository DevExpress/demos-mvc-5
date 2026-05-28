using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class AreaTypesController : DemoController {
        [HttpGet]
        public ActionResult SplineArea3DView() {
            ChartArea3DDemoOptions options = new ChartArea3DDemoOptions() { Data = DevAV.GetOutsideVendorCosts() };
            return DemoView("SplineArea3DView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SplineArea3DView([Bind] ChartArea3DDemoOptions options) {
            options.Data = DevAV.GetOutsideVendorCosts();
            return DemoView("SplineArea3DView", options);
        }
    }
}
