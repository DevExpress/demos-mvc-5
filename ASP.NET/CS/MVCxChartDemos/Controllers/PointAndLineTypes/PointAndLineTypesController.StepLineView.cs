using DevExpress.XtraCharts;
using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class PointAndLineTypesController : DemoController {
        [HttpGet]
        public ActionResult StepLineView() {
            ChartStepLineDemoOptions options = new ChartStepLineDemoOptions();
            options.ShowLabels = true;
            options.MarkerSize = 20;
            options.MarkerKindString = MarkerKind.Square.ToString();
            options.Data = FuelOilPriceProvider.GetFuelOilPrices();
            return DemoView("StepLineView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult StepLineView([Bind] ChartStepLineDemoOptions options) {
            options.Data = FuelOilPriceProvider.GetFuelOilPrices();
            return DemoView("StepLineView", options);
        }
    }
}
