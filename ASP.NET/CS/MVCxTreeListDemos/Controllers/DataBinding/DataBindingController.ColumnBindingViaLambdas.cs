using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DataBindingController: DemoController {
        public ActionResult ColumnBindingViaLambdas() {
            return DemoView("ColumnBindingViaLambdas", NewsGroupsProvider.GetEditablePosts());
        }
        public ActionResult ColumnBindingViaLambdasPartial() {
            return PartialView("ColumnBindingViaLambdasPartial", NewsGroupsProvider.GetEditablePosts());
        }
    }
}
