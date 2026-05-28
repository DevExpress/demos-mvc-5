using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class MailMergeController : DemoController {
        public ActionResult DocVariable() {
            return DemoView("DocVariable");
        }
        public ActionResult DocVariablePartial() {
            return PartialView("DocVariablePartial");
        }
    }
}
