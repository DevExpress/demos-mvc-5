using System.Threading;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ImageGalleryController : DemoController {
        public ActionResult AdaptiveLayout() {
            return DemoView("AdaptiveLayout");
        }
        public ActionResult AdaptiveLayoutPage() {
            return View("AdaptiveLayoutPage");
        }
        public ActionResult AdaptiveLayoutPagePartial() {
            // Intentionally pauses server-side processing,
            // to demonstrate the Loading Panel functionality.
            Thread.Sleep(500);
            return PartialView("AdaptiveLayoutPagePartial");
        }
    }
}
