using System;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SampleDocumentsController : DemoController {
        public ActionResult ProfitAndLoss() {
            return DemoView("ProfitAndLoss");
        }
        public ActionResult ProfitAndLossPartial() {
            return PartialView("SampleDocumentSpreadsheetPartial", "ProfitAndLoss");
        }
    }
}
