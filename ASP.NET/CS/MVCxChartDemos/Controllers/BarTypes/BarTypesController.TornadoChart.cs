using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class BarTypesController : DemoController {
        [HttpGet]
        public ActionResult TornadoChart() {
            ChartStackedBarDemoOptions options = new ChartStackedBarDemoOptions() { Data = AgeStructure.GetGenderAgeItemsWithPopulation(), ShowLabels = false };
            return DemoView("TornadoChart", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TornadoChart([Bind]ChartSideBySideBarDemoOptions options) {
            options.Data = AgeStructure.GetGenderAgeItemsWithPopulation();
            return DemoView("TornadoChart", options);
        }
    }
}
