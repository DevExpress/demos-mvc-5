using DevExpress.Web.ASPxScheduler;
using DevExpress.XtraScheduler;
using System;
using System.Collections;

namespace DevExpress.Web.Demos {
    public class SchedulerTimelineViewDemoOptions {
        public SchedulerTimelineViewDemoOptions() {
            ShowViewNavigator = true;
            ShowViewVisibleInterval = true;
            AppointmentSelectionAppearanceMode = ASPxScheduler.AppointmentSelectionAppearanceMode.Auto;

            AutoHeight = true;
            AppointmentHeight = 40;
            SnapToCellsMode = AppointmentSnapToCellsMode.Auto;
            TimeIndicatorVisibility = XtraScheduler.TimeIndicatorVisibility.Always;

            IntervalCount = 10;
            VisibleIntervalCount = 5;
        }

        public AppointmentSelectionAppearanceMode AppointmentSelectionAppearanceMode { get; set; }
        public bool ShowViewNavigator { get; set; }
        public bool ShowViewVisibleInterval { get; set; }

        public bool AutoHeight { get; set; }
        public int AppointmentHeight { get; set; }
        public AppointmentSnapToCellsMode SnapToCellsMode { get; set; }
        public TimeIndicatorVisibility TimeIndicatorVisibility { get; set; }

        public int IntervalCount { get; set; }
        public int VisibleIntervalCount { get; set; }

        public IEnumerable Appointments { get { return SchedulerDataHelper.DataObject.Appointments; } }
        public IEnumerable Resources { get { return SchedulerDataHelper.DataObject.Resources; } }
    }
}
