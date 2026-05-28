using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AdaptivityController : DemoController {

        public ActionResult ScrollPicker() {
            return DemoView("ScrollPicker");
        }

        public ActionResult ScrollPickerPage() {
            return View("ScrollPickerPage", new ScrollPickerDemoOptions());
        }

        public ActionResult ScrollPickerPage_SettingsPartial() {
            return PartialView("ScrollPickerPage");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ScrollPickerPage([Bind] ScrollPickerDemoOptions model) {
            return View("ScrollPickerPage", model);
        }
    }
}
