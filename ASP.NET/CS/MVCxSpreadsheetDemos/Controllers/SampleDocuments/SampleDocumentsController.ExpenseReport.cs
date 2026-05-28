using System;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SampleDocumentsController : DemoController {
        public ActionResult ExpenseReport() {
            return DemoView("ExpenseReport");
        }
        public ActionResult ExpenseReportPartial() {
            return PartialView("SampleDocumentSpreadsheetPartial", "ExpenseReport");
        }
    }
}
