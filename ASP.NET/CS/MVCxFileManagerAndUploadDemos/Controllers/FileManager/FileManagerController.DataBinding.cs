using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FileManagerController : DemoController {
        public ActionResult DataBinding() {
            return DemoView("DataBinding", FileManagerDemoHelper.ArtsFileSystemProvider);
        }
        [ValidateInput(false)]
        public ActionResult DataBindingPartial() {
            return PartialView("DataBindingPartial", FileManagerDemoHelper.ArtsFileSystemProvider);
        }
    }
}
