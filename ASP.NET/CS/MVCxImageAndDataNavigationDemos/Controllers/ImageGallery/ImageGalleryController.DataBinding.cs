using System.Threading;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ImageGalleryController : DemoController {
        public ActionResult DataBinding() {
            return DemoView("DataBinding");
        }
        public ActionResult DataBindingPartial() {
            // Intentionally pauses server-side processing,
            // to demonstrate the Loading Panel functionality.
            Thread.Sleep(500);
            return PartialView("DataBindingPartial");
        }
    }
}
