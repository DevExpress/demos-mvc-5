using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class PointAndLineTypesController : DemoController {
        [HttpGet]
        public ActionResult StepLine3DView() {
            ChartStepLine3DDemoOptions options = new ChartStepLine3DDemoOptions() { Data = SourceOfEnergy.GetGasolinePrices() };
            return DemoView("StepLine3DView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult StepLine3DView([Bind] ChartStepLine3DDemoOptions options) {
            options.Data = SourceOfEnergy.GetGasolinePrices();
            return DemoView("StepLine3DView", options);
        }
    }
}
