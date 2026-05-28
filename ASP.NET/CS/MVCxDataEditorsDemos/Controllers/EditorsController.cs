using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    [ValidateInput(false)]
    public partial class EditorsController: DemoController {
        public override string Name { get { return "Editors"; } }

        static EditorsController() {
            EmailDataGenerator.Register();
            PersonDataGenerator.Register();
        }

        public ActionResult Index() {
            return CheckBoxList();
        }

        public ActionResult ModelValidation() {
            return RedirectToAction("ModelValidation", "Common");
        }
    }
}
