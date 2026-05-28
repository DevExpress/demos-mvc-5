using System;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FeaturesController : DemoController {
        public ActionResult Comments() {
            return DemoView("Comments");
        }
        public ActionResult CommentsPartial() {
            return PartialView("CommentsPartial");
        }
    }
}
