using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FeaturesController: DemoController {
        public ActionResult HtmlHighlighting() {
            return DemoView("HtmlHighlighting", HtmlHighlightingOptions.CreateDefault());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult HtmlHighlighting([Bind] HtmlHighlightingOptions options) {
            return DemoView("HtmlHighlighting", options);
        }
        public ActionResult HtmlHighlightingPartial(HtmlHighlightingOptions options) {
            return PartialView("HtmlHighlightingPartial", options);
        }
    }
}
