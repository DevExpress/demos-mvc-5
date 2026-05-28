using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ImageGalleryController : DemoController {
        public override string Name { get { return "ImageGallery"; } }

        public ActionResult Index() {
            return RedirectToAction("DataBinding");
        }
    }
}
