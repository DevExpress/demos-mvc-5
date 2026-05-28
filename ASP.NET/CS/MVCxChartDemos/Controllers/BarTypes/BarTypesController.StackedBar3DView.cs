using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class BarTypesController : DemoController {
        [HttpGet]
        public ActionResult StackedBar3DView() {
            ChartBar3DDemoOptions options = new ChartBar3DDemoOptions() { Data = AgeStructure.GetDataByFemaleAge(), ShowLabels = true };
            return DemoView("StackedBar3DView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult StackedBar3DView([Bind]ChartBar3DDemoOptions options) {
            options.Data = AgeStructure.GetDataByFemaleAge();
            return DemoView("StackedBar3DView", options);
        }
    }
}

