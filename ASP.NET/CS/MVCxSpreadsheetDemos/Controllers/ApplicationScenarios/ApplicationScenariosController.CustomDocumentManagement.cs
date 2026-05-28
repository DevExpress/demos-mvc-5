using System;
using System.IO;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ApplicationScenariosController : DemoController {
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
            return SpreadsheetExtension.Open("spreadsheet", Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, filePath));
        }
        public ActionResult DownloadFile() {
            var settings = new DevExpress.Web.Mvc.FileManagerSettings() { Name = "fileManager" };
            settings.SettingsEditing.AllowDownload = true;
            return FileManagerExtension.DownloadFiles(settings, DirectoryManagmentUtils.DocumentBrowsingFolderPath);
        }
    }
}
