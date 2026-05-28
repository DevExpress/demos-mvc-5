using System.Web.Mvc;
using System.Web.UI;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ShapingController : DemoController {
        public ActionResult Templates() {
            return DemoView("Templates", FishCatalog.GetData());
        }
        public ActionResult TemplatesPartial() {
            return PartialView("TemplatesPartial", FishCatalog.GetData());
        }
        public ActionResult LoadNotes(int id) {
            string notes = string.Empty;
            var fish = FishCatalog.GetByKey(id);
            if (fish != null)
                notes = fish.Notes;
            return TreeListExtension.GetCustomDataCallbackResult(notes);
        }
    }
}
