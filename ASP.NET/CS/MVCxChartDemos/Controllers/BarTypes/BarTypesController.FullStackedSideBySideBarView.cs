using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class BarTypesController : DemoController {
        [HttpGet]
        public ActionResult FullStackedSideBySideBarView() {
            ChartSideBySideBarDemoOptions options = new ChartSideBySideBarDemoOptions() { Data = AgeStructure.GetDataByAgeAndGender(), ShowLabels = true };
            return DemoView("FullStackedSideBySideBarView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FullStackedSideBySideBarView([Bind]ChartSideBySideBarDemoOptions options) {
            options.Data = AgeStructure.GetDataByAgeAndGender();
            return DemoView("FullStackedSideBySideBarView", options);
        }
    }
}
