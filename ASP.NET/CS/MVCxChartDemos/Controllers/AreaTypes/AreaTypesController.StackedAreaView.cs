using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class AreaTypesController : DemoController {
        [HttpGet]
        public ActionResult StackedAreaView() {
            ChartAreaDemoOptions options = new ChartAreaDemoOptions() { Data = DevAV.GetSalesByLast10Years() };
            return DemoView("StackedAreaView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult StackedAreaView([Bind] ChartAreaDemoOptions options) {
            options.Data = DevAV.GetSalesByLast10Years();
            return DemoView("StackedAreaView", options);
        }
    }
}
