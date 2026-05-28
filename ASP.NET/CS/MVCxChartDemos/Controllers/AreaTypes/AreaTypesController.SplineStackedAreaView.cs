using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class AreaTypesController : DemoController {
        [HttpGet]
        public ActionResult SplineStackedAreaView() {
            ChartAreaDemoOptions options = new ChartAreaDemoOptions() { Data = DevAV.GetSalesByLast10Years() };
            return DemoView("SplineStackedAreaView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SplineStackedAreaView([Bind] ChartAreaDemoOptions options) {
            options.Data = DevAV.GetSalesByLast10Years();
            return DemoView("SplineStackedAreaView", options);
        }
    }
}
