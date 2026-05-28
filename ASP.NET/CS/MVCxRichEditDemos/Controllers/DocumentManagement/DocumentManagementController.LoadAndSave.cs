using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DocumentManagementController : DemoController {
        public ActionResult LoadAndSave() {
            return DemoView("LoadAndSave");
        }
        public ActionResult LoadAndSavePartial() {
            return PartialView("LoadAndSavePartial");
        }
    }
}
