using System.Web.Mvc;
using DevExpress.Web.ASPxHtmlEditor;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FeaturesController : DemoController {
        public ActionResult PasteProcessing() {
            return DemoView("PasteProcessing", PasteProcessingOptions.CreateDefault());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PasteProcessing([Bind] PasteProcessingOptions options) {
            return DemoView("PasteProcessing", options);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PasteProcessingPartial([Bind] PasteProcessingOptions options) {
            return PartialView("PasteProcessingPartial", options);
        }
    }
}
