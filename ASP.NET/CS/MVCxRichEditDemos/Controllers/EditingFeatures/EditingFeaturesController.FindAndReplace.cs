using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditingFeaturesController : DemoController {
        public ActionResult FindAndReplace() {
            return DemoView("FindAndReplace");
        }
        public ActionResult FindAndReplacePartial() {
            return PartialView("FindAndReplacePartial");
        }
    }
}
