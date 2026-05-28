using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditingFeaturesController : DemoController {
        public ActionResult ParagraphFormatting() {
            return DemoView("ParagraphFormatting");
        }
        public ActionResult ParagraphFormattingPartial() {
            return PartialView("ParagraphFormattingPartial");
        }
    }
}
