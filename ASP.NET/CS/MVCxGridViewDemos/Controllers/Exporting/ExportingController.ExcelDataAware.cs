using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ExportingController: DemoController {
        public ActionResult ExcelDataAware() {
			ViewData["exportRowType"] = GridViewExportedRowType.All;
			return DemoView("ExcelDataAware", NorthwindDataProvider.GetProducts());
        }
        public ActionResult ExcelDataAwarePartial(GridViewExportedRowType? exportRowType) {
			ViewData["exportRowType"] = exportRowType;
			return PartialView("ExcelDataAwarePartial", NorthwindDataProvider.GetProducts());
        }
    }
}
