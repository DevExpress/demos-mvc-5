using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ImageSliderController : DemoController {
        public ActionResult BindingToBinaryData() {
            return DemoView("BindingToBinaryData", BinaryImages.GetData());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BindingToBinaryData(int? categoryId) {
            if (categoryId.HasValue)
                ViewBag.Category = categoryId.ToString();
            return DemoView("BindingToBinaryData", BinaryImages.GetData(categoryId));
        }
    }
}
