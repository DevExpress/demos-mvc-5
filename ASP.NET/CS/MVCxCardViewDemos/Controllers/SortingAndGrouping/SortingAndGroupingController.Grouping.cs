using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SortingAndGroupingController: DemoController {
        public ActionResult Grouping() {
            return DemoView("Grouping", HeadphonesDataProvider.Headphones);
        }
        public ActionResult GroupingPartial() {
            return PartialView("GroupingPartial", HeadphonesDataProvider.Headphones);
        }
    }
}
