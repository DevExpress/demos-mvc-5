using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevExpress.Web.Demos.Controllers {
    public partial class FeaturedShapesController : DemoController {
        public ActionResult Containers() {
            var content = System.IO.File.ReadAllText(MapPath("~/App_Data/diagram-structure.json"));
            return DemoView("Containers", "Containers", content);
        }
    }
}
