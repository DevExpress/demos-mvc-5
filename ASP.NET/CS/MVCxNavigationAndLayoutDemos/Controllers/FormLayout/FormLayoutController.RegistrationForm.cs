using DevExpress.Web.Mvc;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FormLayoutController: DemoController {
        public ActionResult RegistrationForm() {
            return DemoView("RegistrationForm", new RegistrationForm());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RegistrationForm([Bind] RegistrationForm registrationForm) {
            if(ModelState.IsValid && CaptchaExtension.GetIsValid("captcha")) {
                ViewBag.SuccessValidation = true;
                registrationForm = new RegistrationForm();
            }
            return DemoView("RegistrationForm", registrationForm);
        }
        public ActionResult RegistrationFormCaptchaPartialView() {            
            return PartialView();
        }
    }
}
