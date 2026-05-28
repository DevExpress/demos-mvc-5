using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class RibbonController: DemoController {
        public ActionResult ClientSideEvents() {
            return ClientSideEventsDemoView(new string[]{
                "Init",
                "ActiveTabChanged",
                "FileTabClicked",
                "CommandExecuted",
                "MinimizationStateChanged",
                "DialogBoxLauncherClicked"
            });
        }
    }
}
