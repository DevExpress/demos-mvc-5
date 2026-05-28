using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ExportingController : DemoController {
        public override string Name { get { return "Exporting"; } }

        public ActionResult Index() {
            return RedirectToAction("ExportToPdf");
        }
    }
}
