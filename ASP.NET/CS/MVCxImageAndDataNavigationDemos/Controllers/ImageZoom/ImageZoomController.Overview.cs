using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevExpress.Web.Demos
{
    public partial class ImageZoomController: DemoController {
        public ActionResult Overview() {
            return DemoView("Overview");
        }
    }
}
