using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevExpress.Web.Demos.Controllers {
    public partial class DocumentController {
        public ActionResult ReadOnly() {
            var content = System.IO.File.ReadAllText(MapPath("~/App_Data/diagram-structure.json"));
            return DemoView("ReadOnly", "ReadOnly", content);
        }
    }
}
