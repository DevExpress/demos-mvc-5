using System.Web.Mvc;
using System.Collections.Generic;

namespace DevExpress.Web.Demos {
    public partial class FileManagerController : DemoController {
        public ActionResult AccessControl() {
            Session["SecurityRole"] = SecurityRole.DefaultUser.ToString();
            return DemoView("AccessControl", FileManagerDemoHelper.RootFolder);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AccessControl(SecurityRole securityRole) {
            Session["SecurityRole"] = securityRole.ToString();
            return DemoView("AccessControl", FileManagerDemoHelper.RootFolder);
        }
        [ValidateInput(false)]
        public ActionResult AccessControlPartial() {
            return PartialView("AccessControlPartial", FileManagerDemoHelper.RootFolder);
        }
    }
}
