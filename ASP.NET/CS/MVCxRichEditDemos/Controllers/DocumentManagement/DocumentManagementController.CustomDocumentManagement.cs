using System.IO;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DocumentManagementController : DemoController {
        public ActionResult CustomDocumentManagement() {
            return DemoView("CustomDocumentManagement");
        }
        public ActionResult CustomDocumentManagementPartial() {
            return PartialView("CustomDocumentManagementPartial");
        }
        public ActionResult CustomDocumentManagementFileManagerPartial() {
            return PartialView("CustomDocumentManagementFileManagerPartial");
        }
        public ActionResult OpenFile(string filePath) {
            return RichEditExtension.Open("RichEdit", Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, filePath));
        }
        public ActionResult DownloadFile() {
            return FileManagerExtension.DownloadFiles(RichEditDemo.FileManagerHelper.CreateDownloadSettings(), DirectoryManagmentUtils.DocumentBrowsingFolderPath);
        }
    }
}
