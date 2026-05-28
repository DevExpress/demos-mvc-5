using System;
using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class RadarTypesController : DemoController {
        [HttpGet]
        public ActionResult PolarLineView() {
            ChartRadarDemoOptions options = new ChartRadarDemoOptions() {
                PolarFunction = PolarFunctions.Lemniscate,
                ShowMarkers = true,
                Data = MathematicsFunctions.GenerateFunctionPoints(PolarFunctions.Lemniscate)
            };
            return DemoView("PolarLineView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PolarLineView([Bind] ChartRadarDemoOptions options) {
            options.Data = MathematicsFunctions.GenerateFunctionPoints(options.PolarFunction);
            return DemoView("PolarLineView", options);
        }
    }
}
