using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class RadarTypesController : DemoController {
        [HttpGet]
        public ActionResult ScatterRadarLineView() {
            ChartRadarDemoOptions options = new ChartRadarDemoOptions() {
                Data = MathematicsFunctions.GetRadianArchimedeanSpiralPoints(ScatterRadarFunctions.ArchimedeanSpiral),
                ScatterFunction = ScatterRadarFunctions.ArchimedeanSpiral
            };
            return DemoView("ScatterRadarLineView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ScatterRadarLineView([Bind] ChartRadarDemoOptions options) {
            options.Data = MathematicsFunctions.GetRadianArchimedeanSpiralPoints(options.ScatterFunction);
            return DemoView("ScatterRadarLineView", options);
        }
    }
}
