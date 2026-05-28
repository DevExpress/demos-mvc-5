using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class RoundPanelController: DemoController {

        [HttpGet]
        public ActionResult LoadOnDemand() {
            return DemoView("LoadOnDemand");
        }

        public PartialViewResult LoadOnDemandPartial() {
            return PartialView();
        }
        public PartialViewResult RoundPanelContent() {
            // Intentionally pauses server-side processing, 
            // to demonstrate the Loading Panel functionality.
            System.Threading.Thread.Sleep(2000);
            return PartialView();
        }
    }
}
