using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SampleReportsController: DemoController {
        [HttpGet]
        public ActionResult SampleReports() {
            return DemoView("SampleReports", PivotGridReportsDemoOptions.Default);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SampleReports([Bind]PivotGridReportsDemoOptions options) {
            return DemoView("SampleReports", options);
        }

        public ActionResult SampleReportsPartial(PivotGridReportsDemoOptions options) {
            return PartialView("SampleReportsPartial", options);
        }
    }
}
