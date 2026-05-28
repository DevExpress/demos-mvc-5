using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PopupControlController : DemoController {
        public ActionResult Features() {
            return DemoView("Features", new PopupControlFeaturesDemoOptions());
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Features([Bind]PopupControlFeaturesDemoOptions options) {
            if(!ModelState.IsValid) {
                if(!ModelState.IsValidField("Opacity"))
                    options.Opacity = PopupControlFeaturesDemoOptions.DefaultOpacity;
                if(!ModelState.IsValidField("AppearAfter"))
                    options.AppearAfter = PopupControlFeaturesDemoOptions.DefaultAppearAfter;
                if(!ModelState.IsValidField("DisappearAfter"))
                    options.DisappearAfter = PopupControlFeaturesDemoOptions.DefaultDisappearAfter;
            }
            return DemoView("Features", options);
        }
    }
}
