using System;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SampleDocumentsController : DemoController {
        public ActionResult LoanAmortizationSchedule() {
            return DemoView("LoanAmortizationSchedule");
        }
        public ActionResult LoanAmortizationSchedulePartial() {
            return PartialView("SampleDocumentSpreadsheetPartial", "LoanAmortizationSchedule");
        }
    }
}
