using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ImageSliderController : DemoController {
        public ActionResult FolderBinding() {
            object folder = "~/Content/Images/landscapes";
            return DemoView("FolderBinding", folder);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FolderBinding(string folder) {
            return DemoView("FolderBinding", (object)folder);
        }
    }
}
