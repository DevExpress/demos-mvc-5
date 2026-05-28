using System.Web.Mvc;
using DevExpress.Web.ASPxHtmlEditor;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FeaturesController : DemoController {
        public ActionResult Features() {
            return DemoView("Features", FeaturesOptions.CreateDefault());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Features([Bind] FeaturesOptions model) {
            return DemoView("Features", model);
        }
        public ActionResult FeaturesPartial(FeaturesOptions model) {
            return PartialView("FeaturesPartial", model);
        }
    }
}
