using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class APIController : DemoController {
        public ActionResult CommandsAPI() {
            return DemoView("CommandsAPI");
        }
        public ActionResult CommandsAPIPartial() {
            return PartialView("CommandsAPIPartial");
        }
    }
}
