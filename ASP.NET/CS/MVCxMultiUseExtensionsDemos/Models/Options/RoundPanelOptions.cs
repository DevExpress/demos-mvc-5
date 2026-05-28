namespace DevExpress.Web.Demos {
    public class RoundPanelFeaturesDemoOptions {
        public RoundPanelFeaturesDemoOptions() {
            ShowHeader = true;
            View = View.Standard;
            EnableAnimation = true;
            ShowCollapseButton = true;
            AllowCollapsingByHeaderClick = true;
        }

        public bool ShowHeader { get; set; }
        public View View { get; set; }
        public bool EnableAnimation { get; set; }
        public bool ShowCollapseButton { get; set; }
        public bool AllowCollapsingByHeaderClick { get; set; }
    }
}
