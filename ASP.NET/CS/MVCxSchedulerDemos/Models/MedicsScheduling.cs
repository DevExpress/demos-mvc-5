using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Data.Linq;
using System.ComponentModel.DataAnnotations;
using DevExpress.XtraScheduler;

namespace DevExpress.Web.Demos {
    using DevExpress.Web.Mvc;
    using DevExpress.XtraScheduler.Internal.Implementations;

    public static class MedicsSchedulingDataProvider {
        const string MedicsSchedulingDataContextKey = "DXMedicsSchedulingDataContext";

        public static MedicsSchedulingDBContext DB {
            get {
                if(HttpContext.Current.Items[MedicsSchedulingDataContextKey] == null)
                    HttpContext.Current.Items[MedicsSchedulingDataContextKey] = new MedicsSchedulingDBContext();
                return (MedicsSchedulingDBContext)HttpContext.Current.Items[MedicsSchedulingDataContextKey];
            }
        }

        public static IEnumerable GetMedics() {
            return DB.Medics.ToList();
        }
        public static IEnumerable GetAppointments() {
            return DB.MedicalAppointments.ToList();
        }
        public static Binary GetMedicalPhotoById(int id) {
            return (Binary)((from medic in DB.Medics where medic.ID == id select medic.PhotoBytes).SingleOrDefault());
        }
        public static IEnumerable GetImportedAppointments() {
            IEnumerable appointments = (IEnumerable)HttpContext.Current.Session["ImportedAppointments"];
            if(appointments == null)
                appointments = GetAppointments();
            return appointments;
        }
        public static void SetImportedAppointments(IEnumerable appointments) {
            IList<EditableSchedule> listAppointments = new List<EditableSchedule>();
            foreach(EditableSchedule appointment in appointments) {
                appointment.ID = listAppointments.Count + 1;
                listAppointments.Add(appointment);
            }
            HttpContext.Current.Session["ImportedAppointments"] = listAppointments;
        }
        public static IList<T> GetEditableAppointments<T>() where T : ScheduleBase {
            string key = "MedicalSchedule_" + typeof(T).Name;
            IList<T> appointments = (IList<T>)HttpContext.Current.Session[key];

            if(appointments == null) {
                appointments = DB.MedicalAppointments.ToList().Select(schedule => (T)Activator.CreateInstance(typeof(T), schedule)).ToList();
                HttpContext.Current.Session[key] = appointments;
            }
            return appointments;
        }
        public static T GetEditableSchedule<T>(int ID) where T : ScheduleBase {
            return (from carSchedulings in GetEditableAppointments<T>() where carSchedulings.ID == ID select carSchedulings).FirstOrDefault();
        }
        public static void InsertSchedule<T>(ScheduleBase schedule) where T : ScheduleBase {
            if (schedule == null)
                return;

            T editableSchedule = Activator.CreateInstance<T>();
            editableSchedule.Assign(schedule);
            editableSchedule.ID = GetNewScheduleID<T>();
            GetEditableAppointments<T>().Add(editableSchedule);
        }
        public static void UpdateSchedule<T>(T schedule) where T : ScheduleBase {
            if (schedule == null)
                return;

            T editableSchedule = GetEditableSchedule<T>(schedule.ID);
            editableSchedule.Assign(schedule);
        }
        public static void DeleteMedicalScheduling<T>(T schedule) where T : ScheduleBase {
            if (schedule == null)
                return;

            T editableSchedule = GetEditableSchedule<T>(schedule.ID);
            if (editableSchedule != null)
                GetEditableAppointments<T>().Remove(editableSchedule);
        }
        public static int GetNewScheduleID<T>() where T : ScheduleBase {
            IList<T> appointments = GetEditableAppointments<T>();
            return (appointments.Count() > 0) ? appointments.Last().ID + 1 : 0;
        }
    }

    public abstract class SchedulerDataHelperBase {
        public static SchedulerDataObject DataObject {
            get {
                return new SchedulerDataObject() {
                    Appointments = MedicsSchedulingDataProvider.GetAppointments(),
                    Resources = MedicsSchedulingDataProvider.GetMedics()
                };
            }
        }
        public static SchedulerDataObject EditableDataObject {
            get {
                return new SchedulerDataObject() {
                    Appointments = MedicsSchedulingDataProvider.GetEditableAppointments<EditableSchedule>(),
                    Resources = MedicsSchedulingDataProvider.GetMedics()
                };
            }
        }
        public static SchedulerDataObject CustomDataObject {
            get {
                return new SchedulerDataObject() {
                    Appointments = MedicsSchedulingDataProvider.GetEditableAppointments<ValidationSchedule>(),
                    Resources = MedicsSchedulingDataProvider.GetMedics()
                };
            }
        }
    }

    public class SchedulerDataHelper : SchedulerDataHelperBase {
        public static void UpdateEditableDataObject() {
            InsertAppointment();
            UpdateAppointments();
            DeleteAppointments();
        }
        static void InsertAppointment() {
            EditableSchedule[] appointments = GetAppointmentsToInsert<EditableSchedule>(EditableDataObject, SchedulerDemoHelper.DefaultAppointmentStorage);
            foreach(EditableSchedule appointment in appointments) {
                MedicsSchedulingDataProvider.InsertSchedule<EditableSchedule>(appointment);
            }
        }
        static void UpdateAppointments() {
            EditableSchedule[] appointments = GetAppointmentsToUpdate<EditableSchedule>(EditableDataObject, SchedulerDemoHelper.DefaultAppointmentStorage);
            foreach(EditableSchedule appointment in appointments) {
                MedicsSchedulingDataProvider.UpdateSchedule<EditableSchedule>(appointment);
            }
        }
        public static void DeleteAppointments() {
            EditableSchedule[] appointments = GetAppointmentsToRemove<EditableSchedule>(EditableDataObject, SchedulerDemoHelper.DefaultAppointmentStorage);
            foreach(EditableSchedule appointment in appointments) {
                MedicsSchedulingDataProvider.DeleteMedicalScheduling<EditableSchedule>(appointment);
            }
        }

        public static T[] GetAppointmentsToInsert<T>(SchedulerDataObject dataObject, MVCxAppointmentStorage appointmentStorage) where T : ScheduleBase {
            return SchedulerExtension.GetAppointmentsToInsert<T>("scheduler", dataObject.Appointments, dataObject.Resources,
                appointmentStorage, SchedulerDemoHelper.DefaultResourceStorage);
        }
        public static T[] GetAppointmentsToUpdate<T>(SchedulerDataObject dataObject, MVCxAppointmentStorage appointmentStorage) where T : ScheduleBase {
            return SchedulerExtension.GetAppointmentsToUpdate<T>("scheduler", dataObject.Appointments, dataObject.Resources,
                appointmentStorage, SchedulerDemoHelper.DefaultResourceStorage);
        }
        public static T[] GetAppointmentsToRemove<T>(SchedulerDataObject dataObject, MVCxAppointmentStorage appointmentStorage) where T : ScheduleBase {
            return SchedulerExtension.GetAppointmentsToRemove<T>("scheduler", dataObject.Appointments, dataObject.Resources, 
                appointmentStorage, SchedulerDemoHelper.DefaultResourceStorage);
        }
    }

    public class StorageControlDataHelper : SchedulerDataHelperBase {
        public static void UpdateEditableDataObject() {
            InsertAppointment();
            UpdateAppointments();
            DeleteAppointments();
        }
        static void InsertAppointment() {
            EditableSchedule[] appointments = GetAppointmentsToInsert<EditableSchedule>(EditableDataObject, SchedulerDemoHelper.DefaultAppointmentStorage);
            foreach(EditableSchedule appointment in appointments) {
                MedicsSchedulingDataProvider.InsertSchedule<EditableSchedule>(appointment);
            }
        }
        static void UpdateAppointments() {
            EditableSchedule[] appointments = GetAppointmentsToUpdate<EditableSchedule>(EditableDataObject, SchedulerDemoHelper.DefaultAppointmentStorage);
            foreach(EditableSchedule appointment in appointments) {
                MedicsSchedulingDataProvider.UpdateSchedule<EditableSchedule>(appointment);
            }
        }
        public static void DeleteAppointments() {
            EditableSchedule[] appointments = GetAppointmentsToRemove<EditableSchedule>(EditableDataObject, SchedulerDemoHelper.DefaultAppointmentStorage);
            foreach(EditableSchedule appointment in appointments) {
                MedicsSchedulingDataProvider.DeleteMedicalScheduling<EditableSchedule>(appointment);
            }
        }

        public static T[] GetAppointmentsToInsert<T>(SchedulerDataObject dataObject, MVCxAppointmentStorage appointmentStorage) where T : ScheduleBase {
            return SchedulerStorageControlExtension.GetAppointmentsToInsert<T>("storageControl", dataObject.Appointments, dataObject.Resources,
                appointmentStorage, SchedulerDemoHelper.DefaultResourceStorage);
        }
        public static T[] GetAppointmentsToUpdate<T>(SchedulerDataObject dataObject, MVCxAppointmentStorage appointmentStorage) where T : ScheduleBase {
            return SchedulerStorageControlExtension.GetAppointmentsToUpdate<T>("storageControl", dataObject.Appointments, dataObject.Resources,
                appointmentStorage, SchedulerDemoHelper.DefaultResourceStorage);
        }
        public static T[] GetAppointmentsToRemove<T>(SchedulerDataObject dataObject, MVCxAppointmentStorage appointmentStorage) where T : ScheduleBase {
            return SchedulerStorageControlExtension.GetAppointmentsToRemove<T>("storageControl", dataObject.Appointments, dataObject.Resources,
                appointmentStorage, SchedulerDemoHelper.DefaultResourceStorage);
        }

        public static List<CustomAppointmentWrapper> GetAppointmentsWithReminders() {
            List<CustomAppointmentWrapper> result = new List<CustomAppointmentWrapper>();
            MVCxSchedulerStorage storage = new MVCxSchedulerStorage();

            storage.Resources.Assign(SchedulerDemoHelper.DefaultResourceStorage);
            storage.Appointments.Assign(SchedulerDemoHelper.DefaultAppointmentStorage);

            storage.Appointments.DataSource = EditableDataObject.Appointments;
            storage.Resources.DataSource = EditableDataObject.Resources;

            AppointmentBaseCollection appointments = storage.GetAppointments(DateTime.Now.AddMonths(-1), DateTime.Now.AddMonths(1));
            foreach(AppointmentInstance apt in appointments) {
                if(apt.HasReminder)
                    result.Add(new CustomAppointmentWrapper(apt));
            }

            return result;
        }
    }

    public class SchedulerDataObject {
        public IEnumerable Appointments { get; set; }
        public IEnumerable Resources { get; set; }
    }

    public class EditableSchedule : ScheduleBase {
        public EditableSchedule() {
        }
        public EditableSchedule(MedicsSchedulingDb_MedicalAppointments medicalAppointments)
            : base(medicalAppointments) {
                Subject = medicalAppointments.Subject;
                Description = medicalAppointments.Description;
                StartTime = medicalAppointments.StartTime;
                EndTime = medicalAppointments.EndTime;
        }

        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        public override void Assign(ScheduleBase source) {
            base.Assign(source);
            EditableSchedule editableSchedule = source as EditableSchedule;
            if(editableSchedule != null) {
                Subject = editableSchedule.Subject;
                Description = editableSchedule.Description;
                StartTime = editableSchedule.StartTime;
                EndTime = editableSchedule.EndTime;
            }
        }
    }
    public class ValidationSchedule : ScheduleBase {
        public ValidationSchedule() {
        }
        public ValidationSchedule(MedicsSchedulingDb_MedicalAppointments medicalAppointments)
            : base(medicalAppointments) {
                if(medicalAppointments != null) {
                    Subject = medicalAppointments.Subject;
                    StartTime = medicalAppointments.StartTime.Value;
                    EndTime = medicalAppointments.EndTime.Value;
                    Description = medicalAppointments.Description;
                    ContactInfo = medicalAppointments.ContactInfo;
            }
        }

        [Required(ErrorMessage = "The Subject must contain at least one character.")]
        public string Subject { get; set; }
        [Required, Display(Name = "Start time")]
        public DateTime StartTime { get; set; }
        [Required, Display(Name = "End time")]
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        [Display(Name = "Contact info")]
        public string ContactInfo { get; set; }

        public override void Assign(ScheduleBase source) {
            base.Assign(source);
            ValidationSchedule validationSchedule = source as ValidationSchedule;
            if(validationSchedule != null) {
                Subject = validationSchedule.Subject;
                StartTime = validationSchedule.StartTime;
                EndTime = validationSchedule.EndTime;
                Description = validationSchedule.Description;
                ContactInfo = validationSchedule.ContactInfo;
            }
        }

        public static ValidationSchedule ConvertFrom(Appointment appointment) {
            return new ValidationSchedule {
                ID = appointment.Id == null ? -1 : (int)appointment.Id,
                Subject = appointment.Subject,
                Location = appointment.Location,
                StartTime = appointment.Start,
                EndTime = appointment.End,
                Description = appointment.Description,

                ContactInfo = Convert.ToString(appointment.CustomFields["ContactInfo"])
            };
        }
    }

    public abstract class ScheduleBase {
        public ScheduleBase() {
        }
        public ScheduleBase(MedicsSchedulingDb_MedicalAppointments medicalAppointments) {
            if(medicalAppointments != null) {
                ID = medicalAppointments.ID;
                EventType = medicalAppointments.EventType;
                Label = medicalAppointments.Label;
                AllDay = medicalAppointments.AllDay;
                Location = medicalAppointments.Location;
                MedicId = medicalAppointments.MedicId;
                Status = medicalAppointments.Status;
                RecurrenceInfo = medicalAppointments.RecurrenceInfo;
                ReminderInfo = medicalAppointments.ReminderInfo;
            }
        }

        public int ID { get; set; }
        public int? EventType { get; set; }
        public int? Label { get; set; }
        public bool AllDay { get; set; }
        public string Location { get; set; }
        public int? MedicId { get; set; }
        public int? Status { get; set; }
        public string RecurrenceInfo { get; set; }
        public string ReminderInfo { get; set; }

        public virtual void Assign(ScheduleBase source) {
            if (source != null) {
                ID = source.ID;
                EventType = source.EventType;
                Label = source.Label;
                AllDay = source.AllDay;
                Location = source.Location;
                MedicId = source.MedicId;
                Status = source.Status;
                RecurrenceInfo = source.RecurrenceInfo;
                ReminderInfo = source.ReminderInfo;
            }
        }
    }

    public class CustomAppointmentWrapper {
        AppointmentInstance apt;

        public CustomAppointmentWrapper(AppointmentInstance apt) {
            this.apt = apt;
        }

        public object ID { get { return apt.Id; } }
        public string Subject { get { return apt.Subject; } }
        public string AlertTime { get { return apt.Reminder != null ? apt.Reminder.AlertTime.ToLongTimeString() : string.Empty; } }
    }
}
