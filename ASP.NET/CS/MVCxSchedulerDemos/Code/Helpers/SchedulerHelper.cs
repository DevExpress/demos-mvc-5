using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevExpress.Web.Mvc;
using System.Collections;
using DevExpress.XtraScheduler;
using System.Web.UI.WebControls;
using System.Drawing;
using DevExpress.XtraScheduler.iCalendar;
using DevExpress.XtraScheduler.iCalendar.Components;

namespace DevExpress.Web.Demos {
    public class SchedulerDemoHelper {
        public const string ImageQueryKey = "DXImage";

        const string ResourceIdCustomPropertyName = "X-DEVEXPRESS-RESID";
        const string StatusKeyCustomPropertyName = "X-DEVEXPRESS-STATUS";
        const string LabelKeyCustomPropertyName = "X-DEVEXPRESS-LABEL";

        public static string GetMedicalPhotoRouteUrl() {
            return DevExpressHelper.GetUrl(new { Controller = "Customization", Action = "MedicalPhoto" });
        }

        static MVCxAppointmentStorage defaultAppointmentStorage;
        public static MVCxAppointmentStorage DefaultAppointmentStorage {
            get {
                if(defaultAppointmentStorage == null)
                    defaultAppointmentStorage = CreateDefaultAppointmentStorage();
                return defaultAppointmentStorage;
            }
        }

        static MVCxAppointmentStorage CreateDefaultAppointmentStorage() {
            MVCxAppointmentStorage appointmentStorage = new MVCxAppointmentStorage();

            SetupMappings(appointmentStorage);
            SetupLabels(appointmentStorage);
            SetupStatuses(appointmentStorage);

            return appointmentStorage;
        }
        public static void SetupMappings(MVCxAppointmentStorage storage) {
            storage.Mappings.AppointmentId = "ID";
            storage.Mappings.Start = "StartTime";
            storage.Mappings.End = "EndTime";
            storage.Mappings.Subject = "Subject";
            storage.Mappings.Description = "Description";
            storage.Mappings.Location = "Location";
            storage.Mappings.AllDay = "AllDay";
            storage.Mappings.Type = "EventType";
            storage.Mappings.RecurrenceInfo = "RecurrenceInfo";
            storage.Mappings.ReminderInfo = "ReminderInfo";
            storage.Mappings.Label = "Label";
            storage.Mappings.Status = "Status";
            storage.Mappings.ResourceId = "MedicId";
        }
        public static void SetupLabels(MVCxAppointmentStorage storage) {
            storage.Labels.Clear();
            storage.Labels.Add(1, "Routine", "Routine", Color.FromArgb(255, 75, 194, 80));
            storage.Labels.Add(2, "Follow-Up", "Follow-Up", Color.FromArgb(255, 58, 159, 254));
            storage.Labels.Add(3, "Urgent", "Urgent", Color.FromArgb(255, 255, 89, 50));
            storage.Labels.Add(4, "Lab Testing", "Lab Testing", Color.FromArgb(255, 92, 107, 192));
            storage.Labels.Add(5, "Service", "Service", Color.FromArgb(255, 159, 159, 159));
        }
        public static void SetupStatuses(MVCxAppointmentStorage storage) {
            storage.Statuses.Clear();
            storage.Statuses.Add(1, AppointmentStatusType.Custom, "Confirmed", "Confirmed", Color.FromArgb(255, 0, 171, 71));
            storage.Statuses.Add(2, AppointmentStatusType.Custom, "Awaiting Confirmation", "Awaiting Confirmation", Color.FromArgb(255, 94, 53, 177));
            storage.Statuses.Add(3, AppointmentStatusType.Custom, "Cancelled", "Cancelled", Color.FromArgb(255, 255, 255, 255));
        }

        static MVCxResourceStorage defaultResourceStorage;
        public static MVCxResourceStorage DefaultResourceStorage {
            get {
                if(defaultResourceStorage == null)
                    defaultResourceStorage = CreateDefaultResourceStorage();
                return defaultResourceStorage;
            }
        }
        static MVCxResourceStorage CreateDefaultResourceStorage() {
            MVCxResourceStorage resourceStorage = new MVCxResourceStorage();
            resourceStorage.Mappings.ResourceId = "ID";
            resourceStorage.Mappings.Caption = "DisplayName";
            return resourceStorage;
        }

        static MVCxResourceStorage defaultResourceStorageWithImage;
        public static MVCxResourceStorage DefaultResourceStorageWithImage {
            get {
                if(defaultResourceStorageWithImage == null)
                    defaultResourceStorageWithImage = CreateDefaultResourceStorageWithImage();
                return defaultResourceStorageWithImage;
            }
        }
        static MVCxResourceStorage CreateDefaultResourceStorageWithImage() {
            MVCxResourceStorage resourceStorage = CreateDefaultResourceStorage();
            resourceStorage.Mappings.Image = "PhotoBytes";
            return resourceStorage;
        }

        static MVCxAppointmentStorage customAppointmentStorage;
        public static MVCxAppointmentStorage CustomAppointmentStorage {
            get {
                if(customAppointmentStorage == null)
                    customAppointmentStorage = CreateCustomAppointmentStorage();
                return customAppointmentStorage;
            }
        }
        static MVCxAppointmentStorage CreateCustomAppointmentStorage() {
            MVCxAppointmentStorage appointmentStorage = CreateDefaultAppointmentStorage();
            appointmentStorage.CustomFieldMappings.Add("ContactInfo", "ContactInfo");
            return appointmentStorage;
        }

        public static void ApplyCommonViewSettings(DevExpress.Web.ASPxScheduler.DayView view) {
            view.ResourcesPerPage = 1;
            ApplyWorkTime(view);
        }
        static void ApplyWorkTime(DevExpress.Web.ASPxScheduler.DayView view) {
            view.WorkTime.Start = TimeSpan.FromHours(7);
            view.WorkTime.End = TimeSpan.FromHours(20);
            view.ShowWorkTimeOnly = true;
        }

        static SchedulerSettings exportSchedulerSettings;
        public static SchedulerSettings ExportSchedulerSettings {
            get {
                if(exportSchedulerSettings == null)
                    exportSchedulerSettings = CreateExportSchedulerSettings();
                return exportSchedulerSettings;
            }
        }
        static SchedulerSettings CreateExportSchedulerSettings() {
            SchedulerSettings settings = new SchedulerSettings();
            settings.Name = "schedulerExport";
            settings.CallbackRouteValues = new { Controller = "Features", Action = "ICalendarPartial" };
            settings.ActiveViewType = SchedulerViewType.WorkWeek;
            settings.Start = new DateTime(2016, 10, 10);
            settings.GroupType = SchedulerGroupType.Resource;

            settings.Views.DayView.ResourcesPerPage = 4;
            settings.Views.DayView.Styles.ScrollAreaHeight = Unit.Pixel(600);
            settings.Views.WorkWeekView.ResourcesPerPage = 1;
            settings.Views.WorkWeekView.Styles.ScrollAreaHeight = Unit.Pixel(600);
            settings.Views.FullWeekView.Enabled = false;
            settings.Views.WeekView.Enabled = false;
            settings.Views.MonthView.ResourcesPerPage = 1;
            settings.Views.MonthView.AppointmentDisplayOptions.ShowRecurrence = true;
            settings.Views.TimelineView.ResourcesPerPage = 2;

            settings.Storage.EnableReminders = false;
            settings.Storage.Appointments.Assign(DefaultAppointmentStorage);
            settings.Storage.Resources.Assign(DefaultResourceStorage);
            settings.OptionsCustomization.AllowAppointmentCreate = UsedAppointmentType.None;
            settings.OptionsCustomization.AllowAppointmentEdit = UsedAppointmentType.None;
            settings.OptionsCustomization.AllowAppointmentDelete = UsedAppointmentType.None;
            settings.OptionsToolTips.ShowSelectionToolTip = false;

            settings.SettingsExport.ICalendar.AppointmentExporting += (s, e) => {
                iCalendarAppointmentExportingEventArgs args = e as iCalendarAppointmentExportingEventArgs;
                AddICalendarCustomProperty(args, ResourceIdCustomPropertyName, e.Appointment.ResourceId.ToString());
                AddICalendarCustomProperty(args, StatusKeyCustomPropertyName, e.Appointment.StatusKey.ToString());
                AddICalendarCustomProperty(args, LabelKeyCustomPropertyName, e.Appointment.LabelKey.ToString());
            };
            settings.SettingsImport.ICalendar.AppointmentImported += (s, e) => {
                iCalendarAppointmentImportedEventArgs args = e as iCalendarAppointmentImportedEventArgs;
                e.Appointment.ResourceId = Convert.ToInt32(((CustomProperty)args.VEvent.CustomProperties[ResourceIdCustomPropertyName]).Value);
                e.Appointment.StatusKey = Convert.ToInt32(((CustomProperty)args.VEvent.CustomProperties[StatusKeyCustomPropertyName]).Value);
                e.Appointment.StatusKey = Convert.ToInt32(((CustomProperty)args.VEvent.CustomProperties[LabelKeyCustomPropertyName]).Value);
            };

            return settings;
        }
        static void AddICalendarCustomProperty(iCalendarAppointmentExportingEventArgs args, string name, string value) {
            iCalendarPropertyCollection customProperties = args.VEvent.CustomProperties;
            if(customProperties[name] == null)
                customProperties.Add(new CustomProperty(name, value));
            else
                ((CustomProperty)customProperties[name]).Value = value;
        }

        public static SchedulerReportTemplatesDemoOptions ReportTemplatesOptions {
            get {
                const string key = "DXReportTemplatesScheduler";
                var reportTemplatesOptions = HttpContext.Current.Session[key] as SchedulerReportTemplatesDemoOptions;
                if(reportTemplatesOptions == null) {
                    reportTemplatesOptions = new SchedulerReportTemplatesDemoOptions()
                    {
                        ReportTemplateFileName = ReportTemplateFileNames.First(),
                        StartDate = new DateTime(2016, 10, 10),
                        EndDate = new DateTime(2016, 10, 17)
                    };
                    HttpContext.Current.Session[key] = reportTemplatesOptions;
                }
                return reportTemplatesOptions;
            }
        }

        static IEnumerable<string> reportTemplateFileNames;
        public static IEnumerable<string> ReportTemplateFileNames {
            get {
                if(reportTemplateFileNames == null)
                    reportTemplateFileNames = CreateReportTemplateFileNames();
                return reportTemplateFileNames;
            }
        }
        static IEnumerable<string> CreateReportTemplateFileNames() {
            return new List<string>() { "TrifoldStandard.schrepx", "TrifoldResource.schrepx", "TimetableStyle.schrepx",
                "DailyStyleFitToPage.schrepx", "DailyStyleFixedCellHeight.schrepx", "MonthlyStyle.schrepx"};
        }

        static SchedulerSettings reportTemplatesSchedulerSettings;
        public static SchedulerSettings ReportTemplatesSchedulerSettings {
            get {
                if(reportTemplatesSchedulerSettings == null)
                    reportTemplatesSchedulerSettings = CreateReportTemplatesSchedulerSettings();
                return reportTemplatesSchedulerSettings;
            }
        }
        static SchedulerSettings CreateReportTemplatesSchedulerSettings() {
            SchedulerSettings settings = new SchedulerSettings();
            settings.Name = "scheduler";
            settings.CallbackRouteValues = new { Controller = "Reporting", Action = "ReportTemplatesPartial" };
            settings.ActiveViewType = SchedulerViewType.Week;
            settings.GroupType = SchedulerGroupType.Resource;
            settings.Start = new DateTime(2016, 10, 10);

            settings.Views.DayView.ResourcesPerPage = 3;
            settings.Views.DayView.Styles.ScrollAreaHeight = Unit.Pixel(300);
            settings.Views.WorkWeekView.ResourcesPerPage = 1;
            settings.Views.WorkWeekView.Styles.ScrollAreaHeight = Unit.Pixel(300);
            settings.Views.FullWeekView.ResourcesPerPage = 1;
            settings.Views.WeekView.Styles.DateCellBody.Height = Unit.Pixel(150);
            settings.Views.WeekView.ResourcesPerPage = 2;
            settings.Views.FullWeekView.Enabled = true;
            settings.Views.MonthView.ResourcesPerPage = 1;
            settings.Views.TimelineView.ResourcesPerPage = 2;

            settings.Storage.EnableReminders = false;
            settings.Storage.Appointments.Assign(SchedulerDemoHelper.DefaultAppointmentStorage);
            settings.Storage.Resources.Assign(SchedulerDemoHelper.DefaultResourceStorage);
            settings.OptionsCustomization.AllowAppointmentCreate = UsedAppointmentType.None;
            settings.OptionsCustomization.AllowAppointmentEdit = UsedAppointmentType.None;
            settings.OptionsCustomization.AllowAppointmentDelete = UsedAppointmentType.None;
            settings.OptionsToolTips.ShowSelectionToolTip = false;
            return settings;
        }

        static SchedulerSettings dateNavigatorSchedulerSettings;
        public static SchedulerSettings DateNavigatorSchedulerSettings {
            get {
                if(dateNavigatorSchedulerSettings == null)
                    dateNavigatorSchedulerSettings = CreateDateNavigatorSchedulerSettings();
                return dateNavigatorSchedulerSettings;
            }
        }
        static SchedulerSettings CreateDateNavigatorSchedulerSettings() {
            SchedulerSettings settings = new SchedulerSettings();
            settings.Name = "scheduler";
            settings.CallbackRouteValues = new { Controller = "CalendarFeatures", Action = "DateNavigatorPartial" };
            settings.Start = new DateTime(2016, 10, 10);
            settings.GroupType = SchedulerGroupType.Resource;
            settings.ActiveViewType = SchedulerViewType.WorkWeek;

            ApplyCommonViewSettings(settings.Views.DayView);
            ApplyCommonViewSettings(settings.Views.WorkWeekView);
            ApplyCommonViewSettings(settings.Views.FullWeekView);

            settings.Views.DayView.ResourcesPerPage = 3;
            settings.Views.FullWeekView.Enabled = true;
            settings.Views.WeekView.Enabled = false;
            settings.Views.MonthView.ResourcesPerPage = 1;

            settings.Views.WeekView.Enabled = false;
            settings.OptionsBehavior.ShowViewNavigator = false;
            settings.OptionsBehavior.ShowViewSelector = false;

            settings.Storage.EnableReminders = false;
            settings.Storage.Resources.Assign(SchedulerDemoHelper.DefaultResourceStorage);
            settings.Storage.Appointments.Assign(SchedulerDemoHelper.DefaultAppointmentStorage);
            settings.OptionsCustomization.AllowAppointmentCreate = UsedAppointmentType.None;
            settings.OptionsCustomization.AllowAppointmentEdit = UsedAppointmentType.None;
            settings.OptionsCustomization.AllowAppointmentDelete = UsedAppointmentType.None;

            settings.DateNavigatorExtensionSettings.Name = "dateNavigator";
            settings.DateNavigatorExtensionSettings.Properties.Columns = 2;
            settings.DateNavigatorExtensionSettings.Properties.DayNameFormat = DayNameFormat.FirstLetter;
            settings.DateNavigatorExtensionSettings.Properties.BoldAppointmentDates = true;
            return settings;
        }

        static SchedulerStorageControlSettings schedulerStorageControlSettings;
        public static SchedulerStorageControlSettings SchedulerStorageControlSettings {
            get {
                if(schedulerStorageControlSettings == null)
                    schedulerStorageControlSettings = CreateSchedulerStorageControlSettings();
                return schedulerStorageControlSettings;
            }
        }
        static SchedulerStorageControlSettings CreateSchedulerStorageControlSettings() {
            SchedulerStorageControlSettings settings = new SchedulerStorageControlSettings();
            settings.Name = "storageControl";
            settings.CallbackRouteValues = new { Controller = "StandaloneControls", Action = "StorageControlPartial" };
            settings.EditAppointmentRouteValues = new { Controller = "StandaloneControls", Action = "StorageControlEditAppointment" };

            settings.Storage.EnableReminders = true;
            settings.Storage.Resources.Assign(SchedulerDemoHelper.DefaultResourceStorage);
            settings.Storage.Appointments.Assign(SchedulerDemoHelper.DefaultAppointmentStorage);

            settings.ClientSideEvents.ReminderAlert = "OnReminderAlert";
            settings.ClientSideEvents.BeginCallback = "OnSchedulerBeginCallback";

            return settings;
        }

        public static SchedulerStorageControlSettings CreateStandaloneDateNavigatorSettings() {
            SchedulerStorageControlSettings settings = new SchedulerStorageControlSettings();
            settings.Name = "storageControl";
            settings.CallbackRouteValues = new { Controller = "StandaloneControls", Action = "DateNavigatorPartial" };

            settings.Storage.EnableReminders = false;
            settings.Storage.Resources.Assign(SchedulerDemoHelper.DefaultResourceStorage);
            settings.Storage.Appointments.Assign(SchedulerDemoHelper.DefaultAppointmentStorage);

            settings.DateNavigatorExtensionSettings.Name = "dateNavigator";
            settings.DateNavigatorExtensionSettings.Properties.Columns = 2;
            settings.DateNavigatorExtensionSettings.Properties.DayNameFormat = DayNameFormat.FirstLetter;
            settings.DateNavigatorExtensionSettings.Properties.AppointmentDatesHighlightMode = ASPxScheduler.AppointmentDatesHighlightMode.Labels;
            
            DateNavigatorDemoOptions demoOptions = HttpContext.Current.Session["DateNavigatorDemoOptions"] as DateNavigatorDemoOptions;
            if(demoOptions != null) {
                settings.DateNavigatorExtensionSettings.Properties.ShowTodayButton = demoOptions.ShowTodayButton;
                settings.DateNavigatorExtensionSettings.Properties.ShowWeekNumbers = demoOptions.ShowWeekNumbers;
                settings.DateNavigatorExtensionSettings.Properties.AppointmentDatesHighlightMode = demoOptions.AppointmentDatesHighlightMode;
            }

            settings.DateNavigatorExtensionSettings.ClientSideEvents.DayCellCustomHighlight = "OnDayCellCustomHighlight";
            settings.DateNavigatorExtensionSettings.ClientSideEvents.SelectionChanged = "OnSelectionChanged";

            settings.DateNavigatorExtensionSettings.SelectedDate = new DateTime(2016, 10, 17);

            return settings;
        }
    }
}
