using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class TemplatesController: DemoController {
        public ActionResult Card() {
            return DemoView("Card", NorthwindDataProvider.GetEmployees());
        }
        public ActionResult CardPartial() {
            return PartialView("CardPartial", NorthwindDataProvider.GetEmployees());
        }
    }
}
