using DevExpress.Web.ASPxScheduler;
using DevExpress.XtraScheduler;
using System;
using System.Collections;

namespace DevExpress.Web.Demos {
    public class SchedulerDayViewDemoOptions {
        public SchedulerDayViewDemoOptions() {
            ShowViewNavigator = true;
            ShowViewVisibleInterval = true;
            HighlightSelectionHeaders = true;

            SnapToCellsMode = AppointmentSnapToCellsMode.Auto;
            StartTimeVisibility = AppointmentTimeVisibility.Always;
            EndTimeVisibility = AppointmentTimeVisibility.Always;
            AppointmentSelectionAppearanceMode = ASPxScheduler.AppointmentSelectionAppearanceMode.Auto;

            DayCount = 3;
            ShowAllDayArea = true;
            ShowWorkTimeOnly = true;
            ShowDayHeaders = true;
            ShowRecurrence = true;
        }

        public AppointmentSelectionAppearanceMode AppointmentSelectionAppearanceMode { get; set; }
        public bool ShowViewNavigator { get; set; }
        public bool ShowViewVisibleInterval { get; set; }

        public bool HighlightSelectionHeaders { get; set; }

        public int DayCount { get; set; }
        public bool ShowWorkTimeOnly { get; set; }
        public bool ShowAllDayArea { get; set; }
        public bool ShowDayHeaders { get; set; }
        public bool ShowRecurrence { get; set; }
        
        public AppointmentSnapToCellsMode SnapToCellsMode { get; set; }
        public AppointmentTimeVisibility StartTimeVisibility { get; set; }
        public AppointmentTimeVisibility EndTimeVisibility { get; set; }

        public IEnumerable Appointments { get { return SchedulerDataHelper.DataObject.Appointments; } }
        public IEnumerable Resources { get { return SchedulerDataHelper.DataObject.Resources; } }
    }
}
