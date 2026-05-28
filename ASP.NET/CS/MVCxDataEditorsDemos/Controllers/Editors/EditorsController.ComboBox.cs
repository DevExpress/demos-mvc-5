using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditorsController : DemoController {
        public ActionResult ComboBox() {
            return DemoView("ComboBox", NorthwindDataProvider.GetProducts());
        }
        public ActionResult ComboBoxPartial() {            
            return PartialView(NorthwindDataProvider.GetProducts());
        }
        public ActionResult MultiColumnComboBoxPartial() {            
            return PartialView(NorthwindDataProvider.GetCustomers());
        }
    }
}
