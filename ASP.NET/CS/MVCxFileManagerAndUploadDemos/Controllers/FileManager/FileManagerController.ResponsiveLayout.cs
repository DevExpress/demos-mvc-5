using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FileManagerController : DemoController {
        public ActionResult ResponsiveLayout() {
            return DemoView("ResponsiveLayout");
        }
        public ActionResult ResponsiveLayoutPage() {
            return DemoView("ResponsiveLayoutPage", FileManagerDemoHelper.DocumentsRootFolder);
        }
        [ValidateInput(false)]
        public ActionResult ResponsiveLayoutPagePartial() {
            return PartialView("ResponsiveLayoutPagePartial", FileManagerDemoHelper.DocumentsRootFolder);
        }
        public FileStreamResult ResponsiveLayoutPageDownloadFiles() {
            return FileManagerExtension.DownloadFiles(FileManagerDemoHelper.CreateFileManagerGeneralDownloadSettings(), (string)FileManagerDemoHelper.DocumentsRootFolder);
        }
    }
}
