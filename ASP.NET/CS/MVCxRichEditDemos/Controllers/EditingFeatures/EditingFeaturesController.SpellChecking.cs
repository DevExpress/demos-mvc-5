using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditingFeaturesController : DemoController {
        public ActionResult SpellChecking() {
            return DemoView("SpellChecking");
        }
        public ActionResult SpellCheckingPartial() {
            return PartialView("SpellCheckingPartial");
        }
    }
}
