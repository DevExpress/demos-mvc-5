using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditorsController : DemoController {
        public ActionResult ComboBoxItemAppearanceCustomization() {            
            return DemoView("ComboBoxItemAppearanceCustomization");
        }
        public ActionResult ComboBoxItemAppearanceCustomizationPartial() {            
            return PartialView(NorthwindDataProvider.GetCustomers());
        }
    }
}
