using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditingFeaturesController : DemoController {
        public ActionResult HeadersAndFooters() {
            return DemoView("HeadersAndFooters");
        }
        public ActionResult HeadersAndFootersPartial() {
            return PartialView("HeadersAndFootersPartial");
        }
    }
}
