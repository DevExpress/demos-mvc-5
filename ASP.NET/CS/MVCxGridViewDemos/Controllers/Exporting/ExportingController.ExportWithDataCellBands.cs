using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ExportingController : DemoController {
        public ActionResult ExportWithDataCellBands() {
            return DemoView("ExportWithDataCellBands", HomesDataProvider.Homes);
        }
        public ActionResult ExportWithDataCellBandsPartial() {
            return PartialView("ExportWithDataCellBandsPartial", HomesDataProvider.Homes);
        }
    }
}
