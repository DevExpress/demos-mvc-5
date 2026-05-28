using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class TimeHighlightingController : DemoController {
        public override string Name { get { return "TimeHighlighting"; } }

        public ActionResult Index() {
            return RedirectToAction("StripLines");
        }
    }
}
