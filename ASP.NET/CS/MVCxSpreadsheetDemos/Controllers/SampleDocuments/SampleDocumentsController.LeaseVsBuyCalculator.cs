using System;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SampleDocumentsController : DemoController {
        public ActionResult LeaseVsBuyCalculator() {
            return DemoView("LeaseVsBuyCalculator");
        }
        public ActionResult CarLeaseVsBuyCalculatorPartial() {
            return PartialView("SampleDocumentSpreadsheetPartial", "CarLeaseVsBuyCalculator");
        }
    }
}
