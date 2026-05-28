using DevExpress.Web.ASPxScheduler;
using DevExpress.XtraScheduler;
using System;
using System.Collections;

namespace DevExpress.Web.Demos {
    public class SchedulerWeekViewDemoOptions {
        public SchedulerWeekViewDemoOptions() {
            ShowViewNavigator = true;
            ShowViewVisibleInterval = true;
            ShowRecurrence = true;

            AppointmentSelectionAppearanceMode = AppointmentSelectionAppearanceMode.Auto;
            StartTimeVisibility = AppointmentTimeVisibility.Always;
            EndTimeVisibility = AppointmentTimeVisibility.Always;
        }

        public AppointmentSelectionAppearanceMode AppointmentSelectionAppearanceMode { get; set; }
        public AppointmentTimeVisibility StartTimeVisibility { get; set; }
        public AppointmentTimeVisibility EndTimeVisibility { get; set; }

        public bool ShowViewNavigator { get; set; }
        public bool ShowViewVisibleInterval { get; set; }
        public bool ShowRecurrence { get; set; }

        public IEnumerable Appointments { get { return SchedulerDataHelper.DataObject.Appointments; } }
        public IEnumerable Resources { get { return SchedulerDataHelper.DataObject.Resources; } }
    }
}
