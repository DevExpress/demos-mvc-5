using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class RadarTypesController : DemoController {
        [HttpGet]
        public ActionResult ScatterPolarLineView() {
            ChartRadarDemoOptions options = new ChartRadarDemoOptions() {
                Data = MathematicsFunctions.GetDegreeArchimedeanSpiralPoints(ScatterRadarFunctions.ArchimedeanSpiral),
                ScatterFunction = ScatterRadarFunctions.ArchimedeanSpiral
            };
            return DemoView("ScatterPolarLineView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ScatterPolarLineView([Bind] ChartRadarDemoOptions options) {
            options.Data = MathematicsFunctions.GetDegreeArchimedeanSpiralPoints(options.ScatterFunction);
            return DemoView("ScatterPolarLineView", options);
        }
    }
}
