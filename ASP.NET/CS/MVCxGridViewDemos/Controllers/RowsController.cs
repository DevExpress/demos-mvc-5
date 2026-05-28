using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class RowsController: DemoController {
        public override string Name { get { return "Rows"; } }

        public ActionResult Index() {
            return RedirectToAction("FocusedRow");
        }
    }
}
