using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevExpress.Web.Demos.Controllers {
    public partial class DocumentController {
        public ActionResult SimpleView() {
            var content = System.IO.File.ReadAllText(MapPath("~/App_Data/diagram-flow.json"));
            return DemoView("SimpleView", "SimpleView", content);
        }
    }
}
