using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditingFeaturesController : DemoController {
        public ActionResult Sections() {
            return DemoView("Sections");
        }
        public ActionResult SectionsPartial() {
            return PartialView("SectionsPartial");
        }
    }
}
