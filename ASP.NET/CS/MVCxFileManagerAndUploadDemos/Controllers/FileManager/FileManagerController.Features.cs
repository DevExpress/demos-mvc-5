using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FileManagerController : DemoController {
        public ActionResult Features() {
            return DemoView("Features", FileManagerDemoHelper.RootFolder);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Features([Bind]FileManagerFeaturesDemoOptions options) {
            FileManagerDemoHelper.FeaturesDemoOptions = options;
            return DemoView("Features", FileManagerDemoHelper.RootFolder);
        }
        [ValidateInput(false)]
        public ActionResult FeaturesPartial() {
            return PartialView("FeaturesPartial", FileManagerDemoHelper.RootFolder);
        }

    }
}
