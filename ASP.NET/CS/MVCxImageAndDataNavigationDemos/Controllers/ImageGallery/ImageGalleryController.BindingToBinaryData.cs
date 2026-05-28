using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ImageGalleryController : DemoController {
        public ActionResult BindingToBinaryData() {
            return DemoView("BindingToBinaryData", BinaryImages.GetData());
        }
    }
}
