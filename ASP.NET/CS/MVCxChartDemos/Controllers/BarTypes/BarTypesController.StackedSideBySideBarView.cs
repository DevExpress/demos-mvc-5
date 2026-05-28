using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class BarTypesController : DemoController {
        [HttpGet]
        public ActionResult StackedSideBySideBarView() {
            ChartSideBySideBarDemoOptions options = new ChartSideBySideBarDemoOptions() { Data = AgeStructure.GetDataByAgeAndGender(), ShowLabels = false };
            return DemoView("StackedSideBySideBarView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult StackedSideBySideBarView([Bind]ChartSideBySideBarDemoOptions options) {
            options.Data = AgeStructure.GetDataByAgeAndGender();
            return DemoView("StackedSideBySideBarView", options);
        }
    }
}
