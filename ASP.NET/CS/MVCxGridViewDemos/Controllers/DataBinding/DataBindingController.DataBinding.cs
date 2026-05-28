using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DataBindingController: DemoController {
        public ActionResult DataBinding() {
            return DemoView("DataBinding", QuotesProvider.GetQuotes());
        }
        public ActionResult DataBindingPartial() {
            return PartialView("DataBindingPartial", QuotesProvider.GetQuotes());
        }
    }
}
