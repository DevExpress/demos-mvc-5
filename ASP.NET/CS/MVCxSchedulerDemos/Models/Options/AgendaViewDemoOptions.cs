using DevExpress.Web.ASPxScheduler;
using DevExpress.XtraScheduler;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace DevExpress.Web.Demos {
    public class SchedulerAgendaViewDemoOptions {
        public SchedulerAgendaViewDemoOptions() {
            ShowViewNavigator = true;
            ShowViewVisibleInterval = true;

            AppointmentsStatus = AppointmentStatusDisplayType.Bounds;
            DayHeaderOrientation = AgendaDayHeaderOrientation.Auto;

            AllowFixedDayHeaders = true;
            ShowResource = true;
            ShowLabel = true;
            ShowRecurrence = true;
            
            DayCount = 5;
        }

        public bool ShowViewNavigator { get; set; }
        public bool ShowViewVisibleInterval { get; set; }

        public AppointmentStatusDisplayType AppointmentsStatus { get; set; }
        public bool ShowResource { get; set; }
        public bool ShowLabel { get; set; }
        public bool ShowRecurrence { get; set; }
        public int DayCount { get; set; }
        public bool AllowFixedDayHeaders { get; set; }

        public AgendaDayHeaderOrientation DayHeaderOrientation { get; set; }

        public IEnumerable Appointments { get { return SchedulerDataHelper.DataObject.Appointments; } }
        public IEnumerable Resources { 
            get {
                return ((List<MedicsSchedulingDb_Medics>)SchedulerDataHelper.DataObject.Resources).Where(i => i.ID < 3).ToList(); 
            } 
        }
    }
}
