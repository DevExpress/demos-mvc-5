using System;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SampleDocumentsController : DemoController {
        public ActionResult ShiftSchedule() {
            return DemoView("ShiftSchedule");
        }
        public ActionResult ShiftSchedulePartial() {
            return PartialView("SampleDocumentSpreadsheetPartial", "ShiftSchedule");
        }
    }
}
