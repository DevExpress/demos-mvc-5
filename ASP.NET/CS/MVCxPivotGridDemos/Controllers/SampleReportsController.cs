using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SampleReportsController: DemoController {
        public override string Name { get { return "SampleReports"; } }

        public ActionResult Index() {
            return RedirectToAction("SampleReports");
        }
    }
}
