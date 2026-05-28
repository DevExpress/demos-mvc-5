using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DialogsController: DemoController {
        public ActionResult InsertMediaContent() {
            Session["Options"] = new HtmlEditorInsertMediaContentDemoOptions();
            return DemoView("InsertMediaContent", Session["Options"]);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult InsertMediaContent([Bind]HtmlEditorInsertMediaContentDemoOptions options) {
            Session["Options"] = options;
            return DemoView("InsertMediaContent", options);
        }
        public ActionResult InsertMediaContentPartial() {
            return PartialView("InsertMediaContentPartial", Session["Options"]);
        }
    }
}
