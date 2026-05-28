using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class NavBarController: DemoController {
        public ActionResult Features() {
            return DemoView("Features", new NavBarFeaturesDemoOptions());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Features([Bind] NavBarFeaturesDemoOptions options) {
            return DemoView("Features", options);
        }
    }
}
