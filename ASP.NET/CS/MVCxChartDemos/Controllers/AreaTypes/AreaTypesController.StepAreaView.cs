using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class AreaTypesController : DemoController {
        [HttpGet]
        public ActionResult StepAreaView() {
            ChartStepAreaDemoOptions options = new ChartStepAreaDemoOptions() { Data = FuelOilPriceProvider.GetFuelOilPrices() };
            return DemoView("StepAreaView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult StepAreaView([Bind] ChartStepAreaDemoOptions options) {
            options.Data = FuelOilPriceProvider.GetFuelOilPrices();
            return DemoView("StepAreaView", options);
        }
    }
}
