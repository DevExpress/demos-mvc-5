using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ImageGalleryController : DemoController {
        public ActionResult Templates() {
            return DemoView("Templates");
        }
        public ActionResult TemplatesPartial() {
            return PartialView("TemplatesPartial");
        }
    }
}
