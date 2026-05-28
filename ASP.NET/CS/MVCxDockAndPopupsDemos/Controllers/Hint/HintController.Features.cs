using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class HintController : DemoController {
        public ActionResult Features() {
            return DemoView("Features", new HintFeaturesDemoOptions());
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Features([Bind]HintFeaturesDemoOptions options) {
            return DemoView("Features", options);
        }
    }
}
