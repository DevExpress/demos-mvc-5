using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class AreaTypesController : DemoController {
        [HttpGet]
        public ActionResult AreaView() {
            ChartAreaDemoOptions options = new ChartAreaDemoOptions() { Data = DevAV.GetOutsideVendorCosts()};
            return DemoView("AreaView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AreaView([Bind] ChartAreaDemoOptions options) {
            options.Data = DevAV.GetOutsideVendorCosts();
            return DemoView("AreaView", options);
        }
    }
}
