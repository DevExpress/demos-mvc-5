using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class RoundPanelController: DemoController {
        public ActionResult Features() {
            return DemoView("Features", new RoundPanelFeaturesDemoOptions());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Features([Bind]RoundPanelFeaturesDemoOptions options) {
            return DemoView("Features", options);
        }
    }
}
