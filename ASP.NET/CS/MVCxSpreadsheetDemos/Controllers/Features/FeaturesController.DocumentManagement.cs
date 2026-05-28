using System;
using System.IO;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FeaturesController : DemoController {
        public ActionResult DocumentManagement() {
            return DemoView("DocumentManagement");
        }
        public ActionResult DocumentManagementPartial() {
            return PartialView("DocumentManagementPartial");
        }
    }
}
