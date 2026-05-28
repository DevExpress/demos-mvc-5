using DevExpress.Web.Demos.Mvc;
using DevExpress.Web.Mvc;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class CustomizationController : DemoController {
        public ActionResult CustomizationDialog() {
            return DemoView("CustomizationDialog");
        }
        public ActionResult CustomizationDialogPage() {
            return View("CustomizationDialogPage", NorthwindDataProvider.GetProducts());
        }
        public ActionResult CustomizationDialogPagePartial() {
            return PartialView("CustomizationDialogPagePartial", NorthwindDataProvider.GetEditableProducts());
        }
    }
}
