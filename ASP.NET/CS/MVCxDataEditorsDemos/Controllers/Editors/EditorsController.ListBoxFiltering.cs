using DevExpress.Web.Demos.Mvc;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditorsController: DemoController {
        public ActionResult ListBoxFiltering(ListBoxFilteringOptions options) {
            return DemoView("ListBoxFiltering", options);
        }
        public ActionResult ListBoxFilteringPartial(ListBoxFilteringOptions options) {
            options.Customers = NorthwindDataProvider.GetCustomers();
            return PartialView(options);
        }
    }
}
