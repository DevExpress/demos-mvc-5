using System;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FeaturesController : DemoController {
        public ActionResult FloatingActionButton() {
            return DemoView("FloatingActionButton", SchedulerDataHelper.EditableDataObject);
        }
        public ActionResult FloatingActionButtonPartial() {
            return PartialView("FloatingActionButtonPartial", SchedulerDataHelper.EditableDataObject);
        }
        [ValidateInput(false)]
        public ActionResult FloatingActionButtonPartialEditAppointment() {
            try {
                SchedulerDataHelper.UpdateEditableDataObject();
            }
            catch (Exception e) {
                ViewData["SchedulerErrorText"] = e.Message;
            }
            return PartialView("FloatingActionButtonPartial", SchedulerDataHelper.EditableDataObject);
        }
    }
}
