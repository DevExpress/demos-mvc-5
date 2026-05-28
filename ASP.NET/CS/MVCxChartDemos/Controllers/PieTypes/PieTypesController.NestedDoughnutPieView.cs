using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class PieTypesController : DemoController {
        [HttpGet]
        public ActionResult NestedDoughnutPieView() {
            ChartNestedDoughnutDemoOptions options = new ChartNestedDoughnutDemoOptions() { Data = AgeStructure.GetPopulationAgeStructure(), HoleRadiusPercent = 40, InnerIndent = 5 };
            return DemoView("NestedDoughnutPieView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NestedDoughnutPieView([Bind] ChartNestedDoughnutDemoOptions options) {
            options.Data = AgeStructure.GetPopulationAgeStructure();
            return DemoView("NestedDoughnutPieView", options);
        }
    }
}
