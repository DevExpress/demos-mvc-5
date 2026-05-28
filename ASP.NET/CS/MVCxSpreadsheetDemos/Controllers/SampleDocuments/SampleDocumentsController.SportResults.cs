using System;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SampleDocumentsController : DemoController {
        public ActionResult SportResults() {
            return DemoView("SportResults");
        }
        public ActionResult SportResultsPartial() {
            return PartialView("SampleDocumentSpreadsheetPartial", "SportResults");
        }
    }
}
