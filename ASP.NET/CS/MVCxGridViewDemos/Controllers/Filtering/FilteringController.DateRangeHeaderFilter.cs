using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FilteringController: DemoController {
        const GridHeaderFilterMode DefaultHeaderFilterMode = GridHeaderFilterMode.DateRangePicker;

        public ActionResult DateRangeHeaderFilter() {
            return DemoView("DateRangeHeaderFilter", DefaultHeaderFilterMode);
        }
        public ActionResult DateRangeHeaderFilterPartial(GridHeaderFilterMode headerFilterMode = DefaultHeaderFilterMode) {
            ViewBag.HeaderFilterMode = headerFilterMode;
            return PartialView("DateRangeHeaderFilterPartial", PatientsDataGenerator.GetInMemoryData());
        }
    }
}
