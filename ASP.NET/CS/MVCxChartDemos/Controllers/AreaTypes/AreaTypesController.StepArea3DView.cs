using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class AreaTypesController : DemoController {
        [HttpGet]
        public ActionResult StepArea3DView() {
            ChartStepArea3DDemoOptions options = new ChartStepArea3DDemoOptions() { Data = SourceOfEnergy.GetGasolinePrices() };
            return DemoView("StepArea3DView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult StepArea3DView([Bind] ChartStepArea3DDemoOptions options) {
            options.Data = SourceOfEnergy.GetGasolinePrices();
            return DemoView("StepArea3DView", options);
        }
    }
}
