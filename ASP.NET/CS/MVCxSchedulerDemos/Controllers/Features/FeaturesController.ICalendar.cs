using System;
using System.Linq;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FeaturesController: DemoController {
        public ActionResult ICalendar() {
            return DemoView("ICalendar", MedicsSchedulingDataProvider.GetImportedAppointments());
        }
        public ActionResult ICalendarPartial() {
            return PartialView("ICalendarPartial", MedicsSchedulingDataProvider.GetImportedAppointments());
        }
        public ActionResult ChangeStorage() {
            if (IsExportAction())
                return ICalendarExport();
            
            if (IsImportAction())
                return ICalendarImport();

            return RedirectToAction("ICalendar"); //Theme changing
        }
        public ActionResult ICalendarExport() {
            return SchedulerExtension.ExportToICalendar(SchedulerDemoHelper.ExportSchedulerSettings, MedicsSchedulingDataProvider.GetImportedAppointments());
        }
        public ActionResult ICalendarImport() {
            UploadedFile[] files = UploadControlExtension.GetUploadedFiles("schedulerAptImporter");
            if (files.Count() > 0) {
                try {
                    EditableSchedule[] schedules = SchedulerExtension.ImportFromICalendar<EditableSchedule>(SchedulerDemoHelper.ExportSchedulerSettings, files[0].FileContent);
                    MedicsSchedulingDataProvider.SetImportedAppointments(schedules);
                }
                catch (Exception e) {
                    TempData["SchedulerErrorText"] = e.Message;
                }
            }
            return RedirectToAction("ICalendar");
        }
        bool IsExportAction() {
            return Request.Params["Export"] != null;
        }
        bool IsImportAction() {
            return Request.Params["Import"] != null;
        }
    }
}
