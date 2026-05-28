using System;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SampleDocumentsController : DemoController {
        public ActionResult HomeAccounting() {
            return DemoView("HomeAccounting");
        }
        public ActionResult HomeAccountingPartial() {
            return PartialView("SampleDocumentSpreadsheetPartial", "HomeAccounting");
        }
    }
}
