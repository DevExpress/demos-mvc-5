using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditorsController: DemoController {
        public ActionResult Captcha() {
            return DemoView("Captcha");
        }
        public ActionResult CaptchaPartial(CaptchaDemoOptions options) {
            if (Request.Params["isApplyOptions"] != null && bool.Parse(Request.Params["isApplyOptions"]))
                Session["CaptchaOptions"] = options;
            return PartialView("CaptchaPartial");
        }
    }
}
