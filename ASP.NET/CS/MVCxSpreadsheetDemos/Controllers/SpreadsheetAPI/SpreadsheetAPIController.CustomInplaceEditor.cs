using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SpreadsheetAPIController : DemoController {
        public ActionResult CustomInplaceEditor() {
            return DemoView("CustomInplaceEditor");
        }
        public ActionResult CustomInplaceEditorPartial() {
            return PartialView("CustomInplaceEditorPartial");
        }
    }
}
