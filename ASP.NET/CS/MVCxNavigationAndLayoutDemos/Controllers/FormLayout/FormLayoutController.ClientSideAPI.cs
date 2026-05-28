using DevExpress.Web.Mvc;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FormLayoutController: DemoController {
        public ActionResult ClientSideAPI() {
            return DemoView("ClientSideAPI", new RegistrationFormClientSideAPIModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ClientSideAPI([Bind] RegistrationFormClientSideAPIModel model) {
            model.IsNewUser = RadioButtonExtension.GetValue<string>("IsNewUser") == "NewUser";
            return DemoView("ClientSideAPI", model);
        }
    }
}
