using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class GridRowsController : DemoController {
        public ActionResult FixedRows() {
            return DemoView("FixedRows", GetHeadphones());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FixedRows([Bind] FixedRowsDemoOptions options) {
            FixedRowsDemoHelper.Options = options;
            return DemoView("FixedRows", GetHeadphones());
        }
        public ActionResult FixedRowsPartial() {
            return PartialView("FixedRowsPartial", GetHeadphones());
        }
    }
}
