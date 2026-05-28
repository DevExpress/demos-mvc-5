using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FeaturesController : DemoController {
        public ActionResult FullPageEditMode() {
            return DemoView("FullPageEditMode");
        }
        public ActionResult FullPageEditModePartial() {
            return PartialView("FullPageEditModePartial");
        }
    }
}
