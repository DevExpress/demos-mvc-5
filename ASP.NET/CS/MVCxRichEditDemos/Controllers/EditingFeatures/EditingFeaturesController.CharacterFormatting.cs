using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditingFeaturesController : DemoController {
        public ActionResult CharacterFormatting() {
            return DemoView("CharacterFormatting");
        }
        public ActionResult CharacterFormattingPartial() {
            return PartialView("CharacterFormattingPartial");
        }
    }
}
