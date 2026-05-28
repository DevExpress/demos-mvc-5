using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditingFeaturesController : DemoController {
        public ActionResult AutoCorrect() {
            return DemoView("AutoCorrect");
        }
        public ActionResult AutoCorrectPartial() {
            return PartialView("AutoCorrectPartial");
        }
    }
}
