namespace DevExpress.Web.Demos {
    public class ScrollPickerDemoOptions {
        public ScrollPickerDemoOptions() {
            PickerDisplayMode = DatePickerDisplayMode.Auto;
            TimeSectionVisibility = false;
            PickerType = DatePickerType.NotSet;
        }
        public DatePickerDisplayMode? PickerDisplayMode { get; set; }
        public bool? TimeSectionVisibility { get; set; }
        public DatePickerType? PickerType { get; set; }
    }
}
