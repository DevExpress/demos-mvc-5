using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ToolbarsAndUIController : DemoController {
        public ActionResult TagInspector() {
            return DemoView("TagInspector");
        }
        public ActionResult TagInspectorPartial() {
            return PartialView("TagInspectorPartial");
        }
    }
}
