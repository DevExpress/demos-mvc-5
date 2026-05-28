namespace DevExpress.Web.Demos {
    public class TreeViewFeaturesDemoOptions {
        public TreeViewFeaturesDemoOptions() {
            AllowCheckNodes = true;
            AllowSelectNode = true;
            EnableAnimation = true;
            EnableHotTrack = true;
            ShowTreeLines = true;
            ShowExpandButtons = true;
        }

        public bool AllowCheckNodes { get; set; }
        public bool AllowSelectNode { get; set; }
        public bool CheckNodesRecursive { get; set; }
        public bool EnableAnimation { get; set; }
        public bool EnableHotTrack { get; set; }
        public bool ShowTreeLines { get; set; }
        public bool ShowExpandButtons { get; set; }
    }
}
