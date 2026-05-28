using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DialogsController: DemoController {
        public ActionResult CustomDialogs() {
            return DemoView("CustomDialogs");
        }
        public ActionResult CustomDialogsPartial() {
            return PartialView("CustomDialogsPartial");
        }
        public ActionResult InsertTemplateForm() {
            return PartialView("InsertTemplateForm");
        }
        public ActionResult InsertTemplateFormPartial() {
            return PartialView("InsertTemplateFormPartial");
        }
    }
}
