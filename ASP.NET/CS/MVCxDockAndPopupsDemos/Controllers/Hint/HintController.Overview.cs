using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class HintController : DemoController {
        public ActionResult Overview() {
            return DemoView("Overview");
        }
    }
}
