using System;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class CustomizationController: DemoController {
        public ActionResult CustomToolTip() {
            return DemoView("CustomToolTip", SchedulerDataHelper.EditableDataObject);
        }
        public ActionResult CustomToolTipPartial() {
            return PartialView("CustomToolTipPartial", SchedulerDataHelper.EditableDataObject);
        }
        public ActionResult CustomToolTipEditAppointment() {
            try {
                SchedulerDataHelper.UpdateEditableDataObject();
            }
            catch(Exception e) {
                ViewData["SchedulerErrorText"] = e.Message;
            }
            return PartialView("CustomToolTipPartial", SchedulerDataHelper.EditableDataObject);
        }
    }
}
