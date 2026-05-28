using System.Web.Mvc;
using DevExpress.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ExportingController: DemoController {
        public ActionResult ExportDetails() {
			ViewData["exportMode"] = GridViewDetailExportMode.Expanded;
			return DemoView("ExportDetails", NorthwindDataProvider.GetCategories());
        }
        
        public ActionResult ExportDetailsMasterPartial(GridViewDetailExportMode? exportMode) {
			ViewData["exportMode"] = exportMode;
			return PartialView("ExportDetailsMasterPartial", NorthwindDataProvider.GetCategories());
        }
        public ActionResult ExportDetailsDetailPartial(int categoryID) {
            ViewBag.CategoryID = categoryID;
            return PartialView("ExportDetailsDetailPartial", NorthwindDataProvider.GetProducts(categoryID));
        }
    }
}
