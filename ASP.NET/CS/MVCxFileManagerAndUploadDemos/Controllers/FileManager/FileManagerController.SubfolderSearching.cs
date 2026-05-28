using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FileManagerController : DemoController {
        public ActionResult SubfolderSearching() {
            return DemoView("SubfolderSearching", FileManagerDemoHelper.RootFolder);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubfolderSearching([Bind]FileManagerSubfolderSearchingOptions options) {
            FileManagerDemoHelper.SubfolderSearchingDemoOptions = options;
            return DemoView("SubfolderSearching", FileManagerDemoHelper.RootFolder);
        }
        [ValidateInput(false)]
        public ActionResult SubfolderSearchingPartial() {
            return PartialView("SubfolderSearchingPartial", FileManagerDemoHelper.RootFolder);
        }
    }
}
