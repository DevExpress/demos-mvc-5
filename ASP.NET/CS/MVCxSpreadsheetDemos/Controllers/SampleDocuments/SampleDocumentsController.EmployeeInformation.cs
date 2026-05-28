using System;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SampleDocumentsController : DemoController {
        public ActionResult EmployeeInformation() {
            return DemoView("EmployeeInformation");
        }
        public ActionResult EmployeeInformationPartial() {
            return PartialView("SampleDocumentSpreadsheetPartial", "EmployeeInformation");
        }
    }
}
