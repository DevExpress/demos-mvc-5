using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class PointAndLineTypesController : DemoController {
        [HttpGet]
        public ActionResult Line3DView() {
            Chart3DDemoOptions options = new Chart3DDemoOptions() { Data = SourceOfEnergy.GetCoalProduction() };
            return DemoView("Line3DView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Line3DView([Bind] Chart3DDemoOptions options) {
            options.Data = SourceOfEnergy.GetCoalProduction();
            return DemoView("Line3DView", options);
        }
    }
}
