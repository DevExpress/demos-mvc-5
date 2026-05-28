using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class BarTypesController : DemoController {
        [HttpGet]
        public ActionResult StackedSideBySideBar3DView() {
            ChartSideBySideBar3DDemoOptions options = new ChartSideBySideBar3DDemoOptions() { Data = AgeStructure.GetDataByAgeAndGender() };
            return DemoView("StackedSideBySideBar3DView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult StackedSideBySideBar3DView([Bind]ChartSideBySideBar3DDemoOptions options) {
            options.Data = AgeStructure.GetDataByAgeAndGender();
            return DemoView("StackedSideBySideBar3DView", options);
        }
    }
}
