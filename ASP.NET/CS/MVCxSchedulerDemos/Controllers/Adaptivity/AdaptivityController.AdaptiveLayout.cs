using System.Web.Mvc;
using System;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AdaptivityController : DemoController {
        public ActionResult AdaptiveLayout() {
            return DemoView("AdaptiveLayout");
        }
        public ActionResult AdaptiveLayoutPage() {
            return View("AdaptiveLayoutPage", SchedulerDataHelper.EditableDataObject);
        }
        public ActionResult AdaptiveLayoutPagePartial() {
            return PartialView("AdaptiveLayoutPagePartial", SchedulerDataHelper.EditableDataObject);
        }
        [ValidateInput(false)]
        public ActionResult AdaptiveLayoutPagePartialEditAppointment() {
            try {
                SchedulerDataHelper.UpdateEditableDataObject();
            }
            catch(Exception e) {
                ViewData["SchedulerErrorText"] = e.Message;
            }
            return PartialView("AdaptiveLayoutPagePartial", SchedulerDataHelper.EditableDataObject);
        }
    }
}
