using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class TabControlController: DemoController {
        public ActionResult Features() {
            ViewData["Options"] = new TabControlFeaturesDemoOptions();
            return DemoView("Features", ViewData["Options"]);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Features([Bind]TabControlFeaturesDemoOptions options) {
            ViewData["Options"] = options;
            return DemoView("Features", options);
        }
    }
}
