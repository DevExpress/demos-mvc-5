using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class GridLookupController : DemoController {
        public ActionResult MultiSelect() {
            return DemoView("MultiSelect");
        }
        public ActionResult MultiSelectPartial() {
            return PartialView("MultiSelectPartial");
        }
    }
}
