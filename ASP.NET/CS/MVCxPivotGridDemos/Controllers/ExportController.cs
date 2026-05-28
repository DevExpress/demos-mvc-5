using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ExportController : DemoController {
        public override string Name { get { return "Export"; } }

        public ActionResult Index() {
            return RedirectToAction("Export");
        }
    }
}
