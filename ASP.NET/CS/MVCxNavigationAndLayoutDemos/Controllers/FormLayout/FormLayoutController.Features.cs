using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FormLayoutController: DemoController {
        public ActionResult Features() {
            ViewBag.FeaturesDemoOptions = new FormLayoutFeaturesDemoOptions();
            return DemoView("Features", new FormLayoutFeaturesModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Features([Bind] FormLayoutFeaturesModel model, [Bind] FormLayoutFeaturesDemoOptions options) {
            ViewBag.FeaturesDemoOptions = options;
            return DemoView("Features", model);
        }
    }
}
