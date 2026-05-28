using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FileManagerController : DemoController {
        public ActionResult MultipleFilesSelection() {
            Session["FileListViewMode"] = FileListView.Thumbnails;
            return DemoView("MultipleFilesSelection", FileManagerDemoHelper.ImagesRootFolder);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MultipleFilesSelection(FileListView fileListViewMode) {
            Session["FileListViewMode"] = fileListViewMode;
            return DemoView("MultipleFilesSelection", FileManagerDemoHelper.ImagesRootFolder);
        }
        public ActionResult MultipleFilesSelectionPartial() {
            return PartialView("MultipleFilesSelectionPartial", FileManagerDemoHelper.ImagesRootFolder);
        }
    }
}
