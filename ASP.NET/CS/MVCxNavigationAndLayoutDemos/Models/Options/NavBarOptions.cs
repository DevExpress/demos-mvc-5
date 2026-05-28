namespace DevExpress.Web.Demos {
    public class NavBarFeaturesDemoOptions {
        public NavBarFeaturesDemoOptions() {
            AllowExpanding = true;
            AllowSelectItem = true;
            AutoCollapse = false;
            EnableHotTrack = true;
            EnableAnimation = true;
            SaveStateToCookies = false;
        }

        public bool AllowExpanding { get; set; }
        public bool AllowSelectItem { get; set; }
        public bool AutoCollapse { get; set; }
        public bool EnableAnimation { get; set; }
        public bool EnableHotTrack { get; set; }
        public bool SaveStateToCookies { get; set; }
    }
}
