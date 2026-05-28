using System.Threading;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ImageGalleryController : DemoController {
        public ActionResult FolderBinding() {
            return DemoView("FolderBinding", ImageGalleryFolderBindingDemoOptions.Default);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FolderBinding([Bind] ImageGalleryFolderBindingDemoOptions options) {
            return DemoView("FolderBinding", options);
        }
        public ActionResult FolderBindingPartial(ImageGalleryFolderBindingDemoOptions options) {
            // Intentionally pauses server-side processing,
            // to demonstrate the Loading Panel functionality.
            Thread.Sleep(500);
            return PartialView("FolderBindingPartial", options);
        }
    }
}
