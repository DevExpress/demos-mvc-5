namespace DevExpress.Web.Demos {
    public class FileManagerDetailsViewModeDemoOptions {
        public FileManagerDetailsViewModeDemoOptions() {
            AllowColumnResize = true;
            AllowColumnDragDrop = true;
            AllowColumnSort = true;
            ShowHeaderFilterButton = false;
        }

        public bool AllowColumnResize { get; set; }
        public bool AllowColumnDragDrop { get; set; }
        public bool AllowColumnSort { get; set; }
        public bool ShowHeaderFilterButton { get; set; }
    }
}
