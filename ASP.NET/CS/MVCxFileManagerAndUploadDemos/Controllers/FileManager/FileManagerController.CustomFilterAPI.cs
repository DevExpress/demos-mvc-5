using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos { 
    public partial class FileManagerController : DemoController {
        public ActionResult CustomFilterAPI() {
            return DemoView("CustomFilterAPI", FileManagerDemoHelper.CreateCustomFileSystemProvider()); 
        } 
        [ValidateInput(false)]
        public ActionResult CustomFilterAPIPartial() {
            return PartialView("CustomFilterAPIPartial", FileManagerDemoHelper.CreateCustomFileSystemProvider());
        }
        public FileStreamResult CustomFilterAPIDownloadFiles() {
            return FileManagerExtension.DownloadFiles(FileManagerDemoHelper.CreateFileManagerGeneralDownloadSettings(), FileManagerDemoHelper.CreateCustomFileSystemProvider());
        }
        public ActionResult CustomFilterAPICustomFilterAction(string filterArg) {
            if(string.IsNullOrEmpty(filterArg)) {
                ViewData["FilterName"] = string.Empty;
                ViewData["FilterText"] = string.Empty;
            } else {
                string[] filterArgs = filterArg.Split('|');
                ViewData["FilterName"] = filterArgs[0];
                ViewData["FilterText"] = filterArgs[1];
            }
            return PartialView("CustomFilterAPIPartial", FileManagerDemoHelper.CreateCustomFileSystemProvider());
        }
        
    }
}
