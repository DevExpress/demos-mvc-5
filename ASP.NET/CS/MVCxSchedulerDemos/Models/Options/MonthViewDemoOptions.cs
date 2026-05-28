using DevExpress.Web.ASPxScheduler;
using DevExpress.XtraScheduler;
using System;
using System.Collections;

namespace DevExpress.Web.Demos {
    public class SchedulerMonthViewDemoOptions {
        public SchedulerMonthViewDemoOptions() {
            ShowViewNavigator = true;
            ShowViewVisibleInterval = true;
            AppointmentSelectionAppearanceMode = ASPxScheduler.AppointmentSelectionAppearanceMode.Auto;
            HighlightSelectionHeaders = true;

            ShowWeekend = false;
            CompressWeekend = false;
            ShowMoreButtons = true;

            WeekCount = 3;
        }

        public AppointmentSelectionAppearanceMode AppointmentSelectionAppearanceMode { get; set; }
        public bool ShowViewNavigator { get; set; }
        public bool ShowViewVisibleInterval { get; set; }
        public bool HighlightSelectionHeaders { get; set; }

        public bool ShowWeekend { get; set; }
        public bool CompressWeekend { get; set; }
        public bool ShowMoreButtons { get; set; }

        public int WeekCount { get; set; }

        public IEnumerable Appointments { get { return SchedulerDataHelper.DataObject.Appointments; } }
        public IEnumerable Resources { get { return SchedulerDataHelper.DataObject.Resources; } }
    }
}
