using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class AreaTypesController : DemoController {
        [HttpGet]
        public ActionResult Area3DView() {
            ChartArea3DDemoOptions options = new ChartArea3DDemoOptions() { Data = DevAV.GetOutsideVendorCosts() };
            return DemoView("Area3DView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Area3DView([Bind] ChartArea3DDemoOptions options) {
            options.Data = DevAV.GetOutsideVendorCosts();
            return DemoView("Area3DView", options);
        }
    }
}
