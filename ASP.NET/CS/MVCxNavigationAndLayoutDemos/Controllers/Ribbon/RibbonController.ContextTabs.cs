using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class RibbonController : DemoController {
        public ActionResult ContextTabs() {
            return DemoView("ContextTabs");
        }
    }
}
