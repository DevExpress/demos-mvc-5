using DevExpress.Web.ASPxScheduler;
using DevExpress.XtraScheduler;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace DevExpress.Web.Demos {
    public class DateNavigatorDemoOptions {
        public DateNavigatorDemoOptions() {
            ShowTodayButton = true;
            ShowWeekNumbers = true;

            AppointmentDatesHighlightMode = AppointmentDatesHighlightMode.Labels;
        }

        public bool ShowTodayButton { get; set; }
        public bool ShowWeekNumbers { get; set; }

        public AppointmentDatesHighlightMode AppointmentDatesHighlightMode { get; set; }

        public IEnumerable Appointments { get { return SchedulerDataHelper.DataObject.Appointments; } }
        public IEnumerable Resources { 
            get {
                return ((List<MedicsSchedulingDb_Medics>)SchedulerDataHelper.DataObject.Resources).Where(i => i.ID < 2).ToList(); 
            } 
        }
    }
}
