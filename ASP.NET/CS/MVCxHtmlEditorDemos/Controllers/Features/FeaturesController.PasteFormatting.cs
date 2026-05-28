using System.Web.Mvc;
using DevExpress.Web.ASPxHtmlEditor;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FeaturesController: DemoController {
        public ActionResult PasteFormatting() {
            return DemoView("PasteFormatting", PasteFormattingOptions.CreateDefault());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PasteFormatting([Bind] PasteFormattingOptions model) {
            return DemoView("PasteFormatting", model);
        }
        public ActionResult PasteFormattingPartial(PasteFormattingOptions model) {
            return PartialView("PasteFormattingPartial", model);
        }
    }
}
