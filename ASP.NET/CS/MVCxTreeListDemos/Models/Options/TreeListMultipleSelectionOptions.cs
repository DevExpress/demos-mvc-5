namespace DevExpress.Web.Demos {
    public class TreeListMultipleSelectionDemoOptions {
        public bool EnableRecursiveSelection { get; set; }
        public bool AllowSelectAll { get; set; }
        public string SelectMode { get; set; }

        public TreeListMultipleSelectionDemoOptions() {
            SelectMode = "All";
        }
    }
}
