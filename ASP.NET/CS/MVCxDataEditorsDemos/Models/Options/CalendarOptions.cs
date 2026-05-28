namespace DevExpress.Web.Demos {
    public class CalendarDemoOptions {
        public CalendarDemoOptions() {
            PickerType = DatePickerType.NotSet;
            HighlightToday = true;
            HighlightWeekends = true;
            ShowClearButton = true;
            ShowTodayButton = true;
            ShowDayHeaders = true;
            ShowHeader = true;
            ShowWeekNumbers = true;
            EnableMultiSelect = false;
            DisableDates = false;
        }
        public DatePickerType PickerType { get; set; }
        public bool HighlightToday { get; set; }
        public bool HighlightWeekends { get; set; }
        public bool ShowClearButton { get; set; }
        public bool ShowTodayButton { get; set; }
        public bool ShowDayHeaders { get; set; }
        public bool ShowHeader { get; set; }
        public bool ShowWeekNumbers { get; set; }
        public bool EnableMultiSelect { get; set; }
        public bool DisableDates { get; set; }
    }
}
