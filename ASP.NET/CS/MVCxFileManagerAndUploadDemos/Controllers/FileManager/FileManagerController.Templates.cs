using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FileManagerController : DemoController {
        public ActionResult Templates() {
            return DemoView("Templates", FileManagerDemoHelper.RootFolder);
        }
        [ValidateInput(false)]
        public ActionResult TemplatesPartial() {
            return PartialView("TemplatesPartial", FileManagerDemoHelper.RootFolder);
        }
    }
}
