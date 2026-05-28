using System.Collections;

namespace DevExpress.Web.Demos {
    public class ListBoxFilteringOptions {
        public ListBoxFilteringOptions() {
            UseCustomFilteringEditor = false;
            SelectionMode = ListEditSelectionMode.CheckColumn;
            EnableSelectAll = true;
            EnableCallbackMode = false;
        } 
        public bool? UseCustomFilteringEditor { get; set; }
        public ListEditSelectionMode? SelectionMode { get; set; }
        public bool? EnableSelectAll { get; set; }
        public bool? EnableCallbackMode { get; set; }
        public IEnumerable Customers { get; set; }
    }
}
