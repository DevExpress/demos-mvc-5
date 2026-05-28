using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class PointAndLineTypesController : DemoController {
        [HttpGet]
        public ActionResult SplineView() {
            ChartSplineDemoOptions options = new ChartSplineDemoOptions() { Data = PowerConsumptionProvider.GetData() };
            return DemoView("SplineView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SplineView([Bind] ChartSplineDemoOptions options) {
            options.Data = PowerConsumptionProvider.GetData();
            return DemoView("SplineView", options);
        }
    }
}
