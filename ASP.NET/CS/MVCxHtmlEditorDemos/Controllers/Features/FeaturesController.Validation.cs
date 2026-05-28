using System.Web.Mvc;

namespace DevExpress.Web.Demos {

    public partial class FeaturesController : DemoController {
        public ActionResult Validation() {
            ValidationDemoModel model = new ValidationDemoModel();
            model.DemoHtml = HtmlEditorFeaturesDemosHelper.GeHtmlContentByFileName("Validation.htm");
            return DemoView("Validation", model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Validation([Bind][ModelBinder(typeof(ValidationDemoBinder))]ValidationDemoModel model) {
            if(ModelState.IsValid)
                return DemoView("Validation", "ValidationSuccess");
            return DemoView("Validation", model);
        }
        public ActionResult ValidationPartial(ValidationDemoModel model) {
            return PartialView("ValidationPartial", model);
        }
    }
}
