using DevExpress.Web.ASPxScheduler;
using DevExpress.XtraScheduler;
using System;
using System.Collections;

namespace DevExpress.Web.Demos {
    public class SchedulerWorkWeekViewDemoOptions {
        public SchedulerWorkWeekViewDemoOptions() {
            ShowViewNavigator = true;
            ShowViewVisibleInterval = true;
            HighlightSelectionHeaders = true;

            TimeIndicatorVisibility = XtraScheduler.TimeIndicatorVisibility.Always;
            TimeMarkerVisibility = XtraScheduler.TimeMarkerVisibility.Always;
            AppointmentSelectionAppearanceMode = ASPxScheduler.AppointmentSelectionAppearanceMode.Auto;

            ShowAllDayArea = true;
            ShowWorkTimeOnly = true;
            ShowDayHeaders = true;

            Sunday = false;
            Monday = true;
            Tuesday = true;
            Wednesday = true;
            Thursday = true;
            Friday  = true;
            Saturday = false;
        }

        public AppointmentSelectionAppearanceMode AppointmentSelectionAppearanceMode { get; set; }
        public bool ShowViewNavigator { get; set; }
        public bool ShowViewVisibleInterval { get; set; }
        public bool HighlightSelectionHeaders { get; set; }

        public TimeIndicatorVisibility TimeIndicatorVisibility { get; set; }
        public TimeMarkerVisibility TimeMarkerVisibility { get; set; }

        public bool ShowWorkTimeOnly { get; set; }
        public bool ShowAllDayArea { get; set; }
        public bool ShowDayHeaders { get; set; }

        public bool Sunday { get; set; }
        public bool Monday { get; set; }
        public bool Tuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set; }
        public bool Saturday { get; set; }

        public WeekDays WorkDays { 
            get {
                WeekDays weekDays = (WeekDays)0;

                if(Sunday)
                    weekDays |= WeekDays.Sunday;
                if(Monday)
                    weekDays |= WeekDays.Monday;
                if(Tuesday)
                    weekDays |= WeekDays.Tuesday;
                if(Wednesday)
                    weekDays |= WeekDays.Wednesday;
                if(Thursday)
                    weekDays |= WeekDays.Thursday;
                if(Friday)
                    weekDays |= WeekDays.Friday;
                if(Saturday)
                    weekDays |= WeekDays.Saturday;

                return weekDays;
            } 
        }

        public IEnumerable Appointments { get { return SchedulerDataHelper.DataObject.Appointments; } }
        public IEnumerable Resources { get { return SchedulerDataHelper.DataObject.Resources; } }
    }
}
