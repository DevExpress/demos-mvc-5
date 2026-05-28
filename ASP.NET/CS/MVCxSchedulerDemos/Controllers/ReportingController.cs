using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ReportingController: DemoController {
        public override string Name { get { return "Reporting"; } }

        public ActionResult Index() {
            return RedirectToAction("ReportTemplates");
        }
    }
}
