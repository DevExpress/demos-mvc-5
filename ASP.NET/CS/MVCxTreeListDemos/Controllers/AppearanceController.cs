using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AppearanceController : DemoController {
        public override string Name { get { return "Appearance"; } }

        public ActionResult Index() {
            return RedirectToAction("ConditionalFormatting");
        }
    }
}
