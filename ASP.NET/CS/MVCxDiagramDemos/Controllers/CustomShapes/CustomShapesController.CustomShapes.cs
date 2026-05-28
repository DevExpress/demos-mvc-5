using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevExpress.Web.Demos.Controllers {
    public partial class CustomShapesController : DemoController {
        public ActionResult CustomShapes() {
            var content = System.IO.File.ReadAllText(MapPath("~/App_Data/diagram-hardware.json"));
            return DemoView("CustomShapes", "CustomShapes", content);
        }
    }
}
