using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DataVisualizationController : DemoController {
        public override string Name { get { return "DataVisualization"; } }

        public ActionResult Index() {
            return RedirectToAction("ChartsIntegration");
        }
    }
}
