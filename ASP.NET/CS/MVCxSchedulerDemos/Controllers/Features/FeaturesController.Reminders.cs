using System;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using DevExpress.XtraScheduler;

namespace DevExpress.Web.Demos {
    public partial class FeaturesController: DemoController {
        public ActionResult Reminders() {
            return DemoView("Reminders", SchedulerDataHelper.EditableDataObject);
        }
        public ActionResult RemindersPartial() {
            if (Request["CreateAppointment"] != null && bool.Parse(Request["CreateAppointment"]))
                AddNewAppointmentWithReminder();
            return PartialView("RemindersPartial", SchedulerDataHelper.EditableDataObject);
        }
        public ActionResult RemindersPartialEditAppointment() {
            try {
                SchedulerDataHelper.UpdateEditableDataObject();
            }
            catch (Exception e) {
                ViewData["SchedulerErrorText"] = e.Message;
            }
            return PartialView("RemindersPartial", SchedulerDataHelper.EditableDataObject);
        }

        void AddNewAppointmentWithReminder() {
            EditableSchedule schedule = CreateAppointmentWithReminders();
            try {
                MedicsSchedulingDataProvider.InsertSchedule<EditableSchedule>(schedule);
            }
            catch (Exception e) {
                ViewData["SchedulerErrorText"] = e.Message;
            }
        }
        EditableSchedule CreateAppointmentWithReminders() {
            Appointment appointment = SchedulerDemoHelper.DefaultAppointmentStorage.CreateAppointment(AppointmentType.Normal);
            appointment.Start = DateTime.Now + TimeSpan.FromMinutes(5) + TimeSpan.FromSeconds(5);
            appointment.Duration = TimeSpan.FromHours(2);
            appointment.Subject = "Appointment with Reminder";
            appointment.HasReminder = true;
            appointment.Reminder.TimeBeforeStart = TimeSpan.FromMinutes(5);
            appointment.ResourceId = EmptyResourceId.Id;
            appointment.StatusKey = (int)AppointmentStatusType.Busy;
            appointment.LabelKey = 1;
            return SchedulerExtension.ConvertAppointment<EditableSchedule>(appointment, SchedulerDemoHelper.DefaultAppointmentStorage);
        }
    }
}
