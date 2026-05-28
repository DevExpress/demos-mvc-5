using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;
using System;

namespace DevExpress.Web.Demos {
    public partial class SelectionController: DemoController {
        public ActionResult AdvancedSelection(GridViewSelectAllCheckBoxMode selectAllMode = GridViewSelectAllCheckBoxMode.Page) {
            ViewBag.SelectAllCheckBoxMode = selectAllMode;
            return DemoView("AdvancedSelection", NorthwindDataProvider.GetCustomers());
        }
        public ActionResult AdvancedSelectionPartial(GridViewSelectAllCheckBoxMode selectAllMode = GridViewSelectAllCheckBoxMode.Page) {
            ViewBag.SelectAllCheckBoxMode = selectAllMode;
            return PartialView("AdvancedSelectionPartial", NorthwindDataProvider.GetCustomers());
        }
    }
}
