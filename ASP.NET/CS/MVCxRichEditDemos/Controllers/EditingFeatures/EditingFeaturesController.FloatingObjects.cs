using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditingFeaturesController : DemoController {
        public ActionResult FloatingObjects() {
            return DemoView("FloatingObjects");
        }
        public ActionResult FloatingObjectsPartial() {
            return PartialView("FloatingObjectsPartial");
        }
    }
}
