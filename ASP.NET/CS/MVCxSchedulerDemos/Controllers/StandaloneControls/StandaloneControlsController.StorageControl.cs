using System;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using DevExpress.XtraScheduler;
using System.Collections.Generic;

namespace DevExpress.Web.Demos {
    public partial class StandaloneControlsController: DemoController {
        public ActionResult StorageControl() {
            return DemoView("StorageControl", StorageControlDataHelper.EditableDataObject);
        }
        public ActionResult StorageControlPartial() {
            if(Request["CreateAppointment"] != null && bool.Parse(Request["CreateAppointment"]))
                AddNewAppointmentWithReminder();
            return PartialView("StorageControlPartial", StorageControlDataHelper.EditableDataObject);
        }
        public ActionResult GridViewPartial() {
            return PartialView("GridViewPartial", StorageControlDataHelper.GetAppointmentsWithReminders());
        }
        public ActionResult StorageControlEditAppointment() {
            try {
                StorageControlDataHelper.UpdateEditableDataObject();
            }
            catch {
            }
            return PartialView("StorageControlPartial", StorageControlDataHelper.EditableDataObject);
        }

        void AddNewAppointmentWithReminder() {
            EditableSchedule appointment = CreateAppointmentWithReminders();
            try {
                MedicsSchedulingDataProvider.InsertSchedule<EditableSchedule>(appointment);
            }
            catch {
            }
        }
        EditableSchedule CreateAppointmentWithReminders() {
            Appointment appointment = SchedulerDemoHelper.DefaultAppointmentStorage.CreateAppointment(AppointmentType.Normal);
            appointment.Start = DateTime.Now + TimeSpan.FromMinutes(5) + TimeSpan.FromSeconds(5);
            appointment.Duration = TimeSpan.FromHours(2);
            List<EditableSchedule> apts = StorageControlDataHelper.EditableDataObject.Appointments as List<EditableSchedule>;
            appointment.Subject = string.Format("Appointment with Reminder (id: {0}_0)", apts.Count + 1);
            appointment.HasReminder = true;
            appointment.Reminder.TimeBeforeStart = TimeSpan.FromMinutes(5);
            appointment.ResourceId = EmptyResourceId.Id;
            appointment.StatusKey = (int)AppointmentStatusType.Busy;
            appointment.LabelKey = 1;
            return SchedulerExtension.ConvertAppointment<EditableSchedule>(appointment, SchedulerDemoHelper.DefaultAppointmentStorage);
        }
    }
}
