using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class GroupingSortingController: DemoController {
        public ActionResult MergingGroups() {
            ViewBag.EnableMergingGroups = true;
            return DemoView("MergingGroups", NorthwindDataProvider.GetCustomers());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MergingGroups(bool enableMergingGroups = true) {
            ViewBag.EnableMergingGroups = enableMergingGroups;
            return DemoView("MergingGroups", NorthwindDataProvider.GetCustomers());
        }
        public ActionResult MergingGroupsPartial(bool enableMergingGroups = true) {
            ViewBag.EnableMergingGroups = enableMergingGroups;
            return PartialView("MergingGroupsPartial", NorthwindDataProvider.GetCustomers());
        }
    }
}
