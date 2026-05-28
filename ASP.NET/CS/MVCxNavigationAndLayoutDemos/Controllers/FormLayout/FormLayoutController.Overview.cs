using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FormLayoutController: DemoController {     
        public ActionResult Overview() {
            return DemoView("Overview", FormLayoutOverviewModel.CreateDefaultModel());
        }
    }
}
