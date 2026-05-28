using System.Web.Mvc;
using DevExpress.Web.ASPxHtmlEditor;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ToolbarsAndUIController: DemoController {
        public ActionResult ToolbarMode() {
            return DemoView("ToolbarMode", ToolbarModeOptions.CreateDefault());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ToolbarMode([Bind] ToolbarModeOptions model) {
            return DemoView("ToolbarMode", model);
        }
        public ActionResult ToolbarModePartial(ToolbarModeOptions model) {
            return PartialView("ToolbarModePartial", model);
        }
    }
}
