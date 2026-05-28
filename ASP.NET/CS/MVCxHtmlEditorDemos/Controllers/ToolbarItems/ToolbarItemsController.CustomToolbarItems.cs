using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ToolbarItemsController: DemoController {
        public ActionResult CustomToolbarItems() {
            return DemoView("CustomToolbarItems");
        }
        public ActionResult CustomToolbarItemsPartial() {
            return PartialView("CustomToolbarItemsPartial");
        }
    }
}
