using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class TimeHighlightingController : DemoController {
        public ActionResult StripLines() {
            return DemoView("StripLines");
        }
        public ActionResult StripLinesPartial() {
            return PartialView("StripLinesPartial");
        }
    }
}
