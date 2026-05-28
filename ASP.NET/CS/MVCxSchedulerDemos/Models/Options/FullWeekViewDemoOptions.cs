using DevExpress.Web.ASPxScheduler;
using DevExpress.XtraScheduler;
using System;
using System.Collections;

namespace DevExpress.Web.Demos {
    public class SchedulerFullWeekViewDemoOptions {
        public SchedulerFullWeekViewDemoOptions() {
            ShowViewNavigator = true;
            ShowViewVisibleInterval = true;
            HighlightSelectionHeaders = true;
            AppointmentSelectionAppearanceMode = ASPxScheduler.AppointmentSelectionAppearanceMode.Auto;

            ShowAllDayArea = true;
            ShowWorkTimeOnly = true;
            ShowDayHeaders = true;
            ShowRecurrence = true;

            SnapToCellsMode = AppointmentSnapToCellsMode.Auto;
            StartTimeVisibility = AppointmentTimeVisibility.Always;
            EndTimeVisibility = AppointmentTimeVisibility.Always;
        }

        public AppointmentSelectionAppearanceMode AppointmentSelectionAppearanceMode { get; set; }
        public bool ShowViewNavigator { get; set; }
        public bool ShowViewVisibleInterval { get; set; }
        public bool HighlightSelectionHeaders { get; set; }

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
