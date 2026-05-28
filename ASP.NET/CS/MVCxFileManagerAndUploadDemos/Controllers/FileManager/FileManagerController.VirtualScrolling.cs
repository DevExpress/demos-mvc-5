using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FileManagerController : DemoController {
        public ActionResult VirtualScrolling() {
            EnsureDemoDataPrepared();
            return DemoView("VirtualScrolling", FileManagerDemoHelper.VirtualScrollingRootFolder);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult VirtualScrolling(FileListView fileListViewMode, int fileListPageSize) {
            EnsureDemoDataPrepared();
            FileManagerDemoHelper.VirtualScrollingViewMode = fileListViewMode;
            FileManagerDemoHelper.VirtualScrollingPageSize = fileListPageSize;
            return DemoView("VirtualScrolling", FileManagerDemoHelper.VirtualScrollingRootFolder);
        }
        [ValidateInput(false)]
        public ActionResult VirtualScrollingPartial() {
            EnsureDemoDataPrepared();
            return PartialView("VirtualScrollingPartial", FileManagerDemoHelper.VirtualScrollingRootFolder);
        }
        public FileStreamResult VirtualScrollingDownloadFiles() {
            EnsureDemoDataPrepared();
            return FileManagerExtension.DownloadFiles(FileManagerDemoHelper.CreateFileManagerGeneralDownloadSettings(), (string)FileManagerDemoHelper.VirtualScrollingRootFolder);
        }
        void EnsureDemoDataPrepared() {
            FileManagmentUtils.EnsureDemoFilesCreated();
        }
    }
}
