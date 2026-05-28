using System.Web.Mvc;
using DevExpress.Web.Mvc;
using System;

namespace DevExpress.Web.Demos {
    public partial class CommonController : DemoController {
        public ActionResult Overview() {
            return DemoView("Overview");
        }
        public ActionResult CaptchaPartial() {
            return PartialView("CaptchaPartial");
        }
    }
}
