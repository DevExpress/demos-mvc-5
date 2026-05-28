using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class LayoutController : DemoController {
        public ActionResult Groups() {
            return DemoView("Groups", NorthwindDataProvider.GetProductReports());
        }
        public ActionResult GroupsPartial() {
            return PartialView("GroupsPartial", NorthwindDataProvider.GetProductReports());
        }
    }
}
