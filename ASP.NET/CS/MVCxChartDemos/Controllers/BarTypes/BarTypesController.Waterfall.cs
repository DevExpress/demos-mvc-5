using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class BarTypesController : DemoController {
        [HttpGet]
        public ActionResult WaterfallView() {
            WaterfallChartDemoOptions options = new WaterfallChartDemoOptions() { Data = XMLUtils.LoadDataTableFromXml("Carbon.xml", "CarbonContribution"), DataType = DataType.AggregatedData};
            return DemoView("WaterfallView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult WaterfallView([Bind]WaterfallChartDemoOptions options) {
            options.Data = XMLUtils.LoadDataTableFromXml("Carbon.xml", "CarbonContribution");
            return DemoView("WaterfallView", options);
        }
    }
}
