using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class PointAndLineTypesController : DemoController {
        [HttpGet]
        public ActionResult LineView() {
            ChartMarkerDemoOptions options = new ChartMarkerDemoOptions() { Data = PopulationProvider.GetPopulationValues(), MarkerSize = 8 };
            return DemoView("LineView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LineView([Bind] ChartMarkerDemoOptions options) {
            options.Data = PopulationProvider.GetPopulationValues();
            return DemoView("LineView", options);
        }
    }
}
