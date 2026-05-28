using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class RadarTypesController : DemoController {
        [HttpGet]
        public ActionResult PolarRangeAreaView() {
            ChartRadarRangeDemoOptions options = new ChartRadarRangeDemoOptions() {
                ShowMarkers = true,
                ShowMarkers2 = false,
                PolarFunction = PolarFunctions.Lemniscate,
                Data = MathematicsFunctions.GenerateRangeFunctionPoints(PolarFunctions.Lemniscate)
            };
            return DemoView("PolarRangeAreaView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PolarRangeAreaView([Bind] ChartRadarRangeDemoOptions options) {
            options.Data = MathematicsFunctions.GenerateRangeFunctionPoints(options.PolarFunction);
            return DemoView("PolarRangeAreaView", options);
        }
    }
}
