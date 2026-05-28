using DevExpress.Web.Demos.Mvc;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FilteringController : DemoController {
        public ActionResult FilterPopup() {
            return DemoView("FilterPopup", NorthwindDataProvider.GetSalesPerson());
        }
        public ActionResult FilterPopupPartial() {            
            return PartialView("FilterPopupPartial", NorthwindDataProvider.GetSalesPerson());
        }
        public ActionResult FilterPopupPartialCustomAction(bool showOnlyAvailableItems, bool showListBoxSearchUI) {
            ViewBag.ShowOnlyAvailableItems = showOnlyAvailableItems;
            ViewBag.ShowListBoxSearchUI = showListBoxSearchUI;
            return PartialView("FilterPopupPartial", NorthwindDataProvider.GetSalesPerson());
        }
    }
}
