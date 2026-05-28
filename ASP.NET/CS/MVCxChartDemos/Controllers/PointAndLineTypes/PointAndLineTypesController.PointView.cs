using System.Collections.Generic;
using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class PointAndLineTypesController : DemoController {

        [HttpGet]
        public ActionResult PointView() {
            ChartMarkerDemoOptions options = new ChartMarkerDemoOptions() { Data = MathematicsFunctions.GetRandomData(), MarkerSize = 8 };
            return DemoView("PointView", options);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PointView([Bind] ChartMarkerDemoOptions options) {
            options.Data = MathematicsFunctions.GetRandomData();
            return DemoView("PointView", options);
        }

    }
}
