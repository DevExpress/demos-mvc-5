using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditorsController : DemoController {        
        public ActionResult ComboBoxItemTemplate() {
            return DemoView("ComboBoxItemTemplate");
        }
        public ActionResult ComboBoxItemTemplatePartial() {
            return PartialView();
        }
    }
}
