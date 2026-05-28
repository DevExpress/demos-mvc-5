using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class PointAndLineTypesController : DemoController {
        [HttpGet]
        public ActionResult ScatterLineView() {
            ChartScatterDemoOptions options = new ChartScatterDemoOptions() { Data = MathematicsFunctions.GetArchimedeanSpiralPoints() };
            return DemoView("ScatterLineView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ScatterLineView([Bind] ChartScatterDemoOptions options) {
            switch (options.FunctionType) {
                case ScatterFunctions.ArchimedeanSpiral:
                    options.Data = MathematicsFunctions.GetArchimedeanSpiralPoints();
                    break;
                case ScatterFunctions.Cardioid:
                    options.Data = MathematicsFunctions.GetCardioidPoints();
                    break;
                case ScatterFunctions.CartesianFolium:
                    options.Data = MathematicsFunctions.GetCartesianFoliumPoints();
                    break;
                default:
                    options.Data = MathematicsFunctions.GetArchimedeanSpiralPoints();
                    break;
            }
            return DemoView("ScatterLineView", options);
        }
    }
}
