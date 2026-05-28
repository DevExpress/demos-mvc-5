using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class MenuController: DemoController {
        public ActionResult Features() {
            return DemoView("Features", new MenuFeaturesDemoOptions());
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Features([Bind]MenuFeaturesDemoOptions options) {
            if(!ModelState.IsValid) {
                if(!ModelState.IsValidField("AppearAfter"))
                    options.AppearAfter = MenuFeaturesDemoOptions.DefaultAppearAfter;
                if(!ModelState.IsValidField("DisappearAfter"))
                    options.DisappearAfter = MenuFeaturesDemoOptions.DefaultDisappearAfter;
                if(!ModelState.IsValidField("MaximumDisplayLevels"))
                    options.MaximumDisplayLevels = MenuFeaturesDemoOptions.DefaultMaximumDisplayLevels;
            }
            return DemoView("Features", options);
        }
    }
}
