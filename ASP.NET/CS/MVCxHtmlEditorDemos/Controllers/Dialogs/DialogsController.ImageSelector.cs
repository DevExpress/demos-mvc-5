using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DialogsController : DemoController {
        public ActionResult ImageSelector() {
            return DemoView("ImageSelector", ImageSelectorOptions.CreateDefault());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ImageSelector([Bind] ImageSelectorOptions options) {
            return DemoView("ImageSelector", options);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ImageSelectorPartial([Bind] ImageSelectorOptions options) {
            return PartialView("ImageSelectorPartial", options);
        }
    }
}
