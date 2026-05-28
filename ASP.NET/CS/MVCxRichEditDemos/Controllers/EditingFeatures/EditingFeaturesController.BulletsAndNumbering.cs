using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditingFeaturesController : DemoController {
        public ActionResult BulletsAndNumbering() {
            return DemoView("BulletsAndNumbering");
        }
        public ActionResult BulletsAndNumberingPartial() {
            return PartialView("BulletsAndNumberingPartial");
        }
    }
}
