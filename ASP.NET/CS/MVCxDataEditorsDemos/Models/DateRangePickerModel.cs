using System;
using System.ComponentModel.DataAnnotations;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public class DateRangePickerModel {
        [Display(Name = "Start Date")]
        public DateTime Start { get; set; }

        [Display(Name = "End Date")]
        [DateRange(StartDateEditFieldName = "Start", MinDayCount = 1, MaxDayCount = 30)]
        public DateTime End { get; set; }
    }
}
