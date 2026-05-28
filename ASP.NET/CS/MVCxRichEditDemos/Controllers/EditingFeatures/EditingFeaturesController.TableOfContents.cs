using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditingFeaturesController : DemoController {
        public ActionResult TableOfContents() {
            return DemoView("TableOfContents");
        }
        public ActionResult TableOfContentsPartial() {
            return PartialView("TableOfContentsPartial");
        }
    }
}
