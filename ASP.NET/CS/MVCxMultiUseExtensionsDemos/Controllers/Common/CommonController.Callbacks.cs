using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class CommonController: DemoController {
        public ActionResult Callbacks() {
            return DemoView("Callbacks");
        }
        public ActionResult CallbacksPartial(string selectedMenuItemName) {
            string actionName = string.Format("Callbacks{0}Partial", selectedMenuItemName);
            object model = null;
            if (selectedMenuItemName == "DataMining")
                model = NorthwindDataProvider.GetCustomerReports();
            else if (selectedMenuItemName == "Visualization")
                model = NorthwindDataProvider.GetProducts("Confections");
            return PartialView(actionName, model);
        }
        public ActionResult CallbacksDataMiningPartial() {
            return PartialView("CallbacksDataMiningPartial", NorthwindDataProvider.GetCustomerReports());
        }
    }
}
