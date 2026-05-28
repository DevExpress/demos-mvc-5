using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FileManagerController : DemoController {
        public override string Name { get { return "FileManager"; } }

        public ActionResult Index() {
            return RedirectToAction("Features");
        }
        public FileStreamResult DownloadFiles() {
            return FileManagerExtension.DownloadFiles(FileManagerDemoHelper.CreateFileManagerDownloadSettings(), (string)FileManagerDemoHelper.RootFolder);
        }
        public FileStreamResult DownloadImages() {
            return FileManagerExtension.DownloadFiles(FileManagerDemoHelper.CreateMultipleFilesSelectionDownloadSettings(), (string)FileManagerDemoHelper.ImagesRootFolder);
        }
    }
}
