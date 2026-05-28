using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class AreaTypesController : DemoController {
        [HttpGet]
        public ActionResult SplineAreaView() {
            ChartAreaDemoOptions options = new ChartAreaDemoOptions() { Data = DevAV.GetOutsideVendorCosts() };
            return DemoView("SplineAreaView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SplineAreaView([Bind] ChartAreaDemoOptions options) {
            options.Data = DevAV.GetOutsideVendorCosts();
            return DemoView("SplineAreaView", options);
        }
    }
}
