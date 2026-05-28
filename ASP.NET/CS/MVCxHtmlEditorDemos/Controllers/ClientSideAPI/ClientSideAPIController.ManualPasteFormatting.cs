using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ClientSideAPIController: DemoController {
        public ActionResult ManualPasteFormatting() {
            ViewData["ShowEventListPanel"] = false;
            Session["Options"] = new HtmlEditorManualPasteFormattingDemoOptions();
            return DemoView("ManualPasteFormatting");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ManualPasteFormatting([Bind]HtmlEditorManualPasteFormattingDemoOptions options) {
            Session["Options"] = options;
            return DemoView("ManualPasteFormatting");
        }
        public ActionResult ManualPasteFormattingPartial() {
            return PartialView("ManualPasteFormattingPartial");
        }
    }

    public class HtmlEditorManualPasteFormattingDemoOptions {
        public bool Bold { get; set; }
        public bool Italic { get; set; }
        public bool Underline { get; set; }
    }
}
