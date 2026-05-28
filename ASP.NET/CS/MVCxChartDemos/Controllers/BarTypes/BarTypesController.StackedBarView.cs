using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class BarTypesController : DemoController {
        [HttpGet]
        public ActionResult StackedBarView() {
            ChartStackedBarDemoOptions options = new ChartStackedBarDemoOptions() { Data = AgeStructure.GetDataByMaleAge(), ShowLabels = true };
            return DemoView("StackedBarView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult StackedBarView([Bind]ChartStackedBarDemoOptions options) {
            options.Data = AgeStructure.GetDataByMaleAge();
            return DemoView("StackedBarView", options);
        }
    }
}

