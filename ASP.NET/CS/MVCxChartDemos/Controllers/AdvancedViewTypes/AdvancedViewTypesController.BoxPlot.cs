using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class AdvancedViewTypesController : DemoController {
        public ActionResult BoxPlot() {
            ChartBoxPlotDemoOptions options = new ChartBoxPlotDemoOptions();
            options.Data = BoxPlotDataProvider.GetData();
            return DemoView("BoxPlot", options);
        }
        public ActionResult BoxPlotPartial(ChartBoxPlotDemoOptions options) {
            options.Data = BoxPlotDataProvider.GetModifiedData();
            return PartialView("BoxPlotPartial", options);
        }
    }
}
