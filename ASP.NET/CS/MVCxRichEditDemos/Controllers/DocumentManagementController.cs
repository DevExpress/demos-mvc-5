using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DocumentManagementController : DemoController {
        public override string Name { get { return "DocumentManagement"; } }

        public ActionResult Index() {
            return RedirectToAction("LoadAndSave");
        }
    }
}
