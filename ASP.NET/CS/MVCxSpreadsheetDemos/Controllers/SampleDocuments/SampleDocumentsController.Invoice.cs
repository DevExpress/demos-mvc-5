using System;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SampleDocumentsController : DemoController {
        public ActionResult Invoice() {
            return DemoView("Invoice");
        }
        public ActionResult InvoicePartial() {
            return PartialView("SampleDocumentSpreadsheetPartial", "Invoice");
        }
    }
}
