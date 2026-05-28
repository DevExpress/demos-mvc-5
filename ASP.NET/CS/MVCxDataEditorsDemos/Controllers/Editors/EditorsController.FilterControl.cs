using DevExpress.Web.Demos.Mvc;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditorsController : DemoController {
        public ActionResult FilterControl() {
            return DemoView("FilterControl");
        }
        public ActionResult FilterControlPartial() {
            return PartialView();
        }
        public ActionResult FilterControl_GridPartial() {
            return PartialView(NorthwindDataProvider.GetProducts());
        }
    }
}
