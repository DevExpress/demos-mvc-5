using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class RadarTypesController : DemoController {
        [HttpGet]
        public ActionResult PolarPointView() {
            ChartRadarDemoOptions options = new ChartRadarDemoOptions() {
                PolarFunction = PolarFunctions.Lemniscate,
                Data = MathematicsFunctions.GenerateFunctionPoints(PolarFunctions.Lemniscate)
            };
            return DemoView("PolarPointView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PolarPointView([Bind] ChartRadarDemoOptions options) {
            options.Data = MathematicsFunctions.GenerateFunctionPoints(options.PolarFunction);
            return DemoView("PolarPointView", options);
        }
    }
}
