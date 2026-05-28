using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FileManagerController : DemoController {
        public ActionResult ClientSideEvents() {
            return ClientSideEventsDemoView(new string[] {
                "Init", "ItemMoving", "ItemMoved", "ItemRenaming", "ItemRenamed", "ItemDeleting", "ItemDeleted",
                "FilesUploading", "FileUploaded", "FolderCreating", "FolderCreated", "ErrorOccurred", "SelectedFileChanged",
                "CurrentFolderChanged", "SelectedFileOpened", "FileDownloading"
            }, FileManagerDemoHelper.RootFolder);
        }
        [ValidateInput(false)]
        public ActionResult ClientSideEventsPartial() {
            return PartialView("ClientSideEventsPartial", FileManagerDemoHelper.RootFolder);
        }
    }
}
