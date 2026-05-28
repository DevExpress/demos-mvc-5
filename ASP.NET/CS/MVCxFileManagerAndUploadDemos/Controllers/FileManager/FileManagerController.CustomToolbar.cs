using System.IO;
using System.Web;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FileManagerController : DemoController {
        public ActionResult CustomToolbar() {
            return DemoView("CustomToolbar", FileManagerDemoHelper.RootFolder);
        }
        public ActionResult CustomToolbarPartial() {
            return PartialView("CustomToolbarPartial", FileManagerDemoHelper.RootFolder);
        }
        public ActionResult CustomToolbarAction(string viewType) {
            HttpContext.Session["aspxCustomToolbarDemoView"] = viewType == "Thumbnails" ? FileListView.Thumbnails : FileListView.Details;
            return PartialView("CustomToolbarPartial", FileManagerDemoHelper.RootFolder);
        }
        public ActionResult CustomToolbarPopupPartial(string relativePath) {
            FileManagerItemInfo itemInfo = CreateFileManagerItemInfo(relativePath);
            return PartialView("CustomToolbarPopupPartial", itemInfo);
        }
        FileManagerItemInfo CreateFileManagerItemInfo(string relativePath) {
            if(string.IsNullOrEmpty(relativePath))
                return new FileManagerItemInfo();
            string path = Path.Combine(FileManagerDemoHelper.FileManagerFolder.ToString(), relativePath).Replace("\\", "/");
            return FileManagerItemInfo.Create(relativePath.Replace("\\", "/"), path);
        }
    }
}
