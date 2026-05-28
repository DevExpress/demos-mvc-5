using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FeaturesController : DemoController {
        public ActionResult FreezePanes() {
            return DemoView("FreezePanes");
        }
        public ActionResult FreezePanesPartial() {
            return PartialView("FreezePanesPartial");
        }
    }
}
