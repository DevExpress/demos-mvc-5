using System.Web.Mvc;
using System.Web.UI;
using DevExpress.Web.Mvc;
namespace DevExpress.Web.Demos {
    public partial class FilteringController : DemoController {
        public ActionResult DateRangeHeaderFilter(GridHeaderFilterMode headerFilterMode = GridHeaderFilterMode.DateRangePicker) {
            return DemoView("DateRangeHeaderFilter", headerFilterMode);
        }
        public ActionResult DateRangeHeaderFilterPartial(GridHeaderFilterMode headerFilterMode = GridHeaderFilterMode.DateRangePicker) {
            ViewBag.HeaderFilterMode = headerFilterMode;
            return PartialView("DateRangeHeaderFilterPartial", NewsGroupsProvider.GetEditablePosts(true));
        }
    }
}
