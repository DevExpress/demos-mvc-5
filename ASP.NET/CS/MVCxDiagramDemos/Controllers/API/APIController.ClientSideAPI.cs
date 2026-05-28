using System.Web.Mvc;

namespace DevExpress.Web.Demos.Controllers {
    public partial class APIController : DemoController {
        public ActionResult ClientSideAPI() {
            var content = System.IO.File.ReadAllText(MapPath("~/App_Data/diagram-tree-structure.json"));
            return DemoView("ClientSideAPI", "ClientSideAPI", content);
        }
    }
}
