using System.Web.Mvc;
using DevExpress.Web.Mvc;
using System.Threading;

namespace DevExpress.Web.Demos {
    public partial class FileManagerController: DemoController {
        public ActionResult Overview() {
            return DemoView("Overview", FileManagerDemoHelper.RootFolder);
        }
        [ValidateInput(false)]
        public ActionResult OverviewPartial() {
            return PartialView("OverviewPartial", FileManagerDemoHelper.RootFolder);
        }
    }
}
