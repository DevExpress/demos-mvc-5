using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class RadarTypesController : DemoController {
        [HttpGet]
        public ActionResult PolarAreaView() {
            ChartRadarDemoOptions options = new ChartRadarDemoOptions() {
                PolarFunction = PolarFunctions.Lemniscate,
                ShowMarkers = true,
                Data = MathematicsFunctions.GenerateFunctionPoints(PolarFunctions.Lemniscate)
            };
            return DemoView("PolarAreaView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PolarAreaView([Bind] ChartRadarDemoOptions options) {
            options.Data = MathematicsFunctions.GenerateFunctionPoints(options.PolarFunction);
            return DemoView("PolarAreaView", options);
        }
    }
}
