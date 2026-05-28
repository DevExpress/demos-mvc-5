using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class GroupingSortingController: DemoController {
        public ActionResult FixedGroups() {
            return DemoView("FixedGroups", NorthwindDataProvider.GetCustomers());
        }
        public ActionResult FixedGroupsPartial() {
            return PartialView("FixedGroupsPartial", NorthwindDataProvider.GetCustomers());
        }
    }
}
