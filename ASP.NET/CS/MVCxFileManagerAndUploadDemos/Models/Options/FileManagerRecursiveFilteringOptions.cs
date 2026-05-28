namespace DevExpress.Web.Demos {
    public class FileManagerSubfolderSearchingOptions {
        public FileManagerSubfolderSearchingOptions() {
            SearchFilesInSubfolders = true;
            SearchResultView = FileManagerFilteredFileListViewMode.Auto;
            FileListView = Web.FileListView.Thumbnails;
        }

        public bool SearchFilesInSubfolders { get; set; }
        public FileManagerFilteredFileListViewMode SearchResultView { get; set; }
        public FileListView FileListView { get; set; }

    }
}
