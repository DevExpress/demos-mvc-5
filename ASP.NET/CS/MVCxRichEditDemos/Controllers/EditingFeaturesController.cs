using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditingFeaturesController : DemoController {
        public override string Name { get { return "EditingFeatures"; } }

        public ActionResult Index() {
            return RedirectToAction("CharacterFormatting");
        }
    }
}
