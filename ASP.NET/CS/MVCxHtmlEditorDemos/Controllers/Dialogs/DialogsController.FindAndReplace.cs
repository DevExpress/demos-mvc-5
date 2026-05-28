using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DialogsController : DemoController {
        public ActionResult FindAndReplace() {
            return DemoView("FindAndReplace");
        }
        public ActionResult FindAndReplacePartial() {
            return PartialView("FindAndReplacePartial");
        }
    }
}
