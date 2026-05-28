using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditorsController : DemoController {
        [HttpGet]
        public ActionResult ListBox() {
            ListBoxDemoHelper.LoadXmlDocument(Server.MapPath("~/App_Data/PhoneModels.xml"));
            ListBoxDemoHelper.ResetFiltration();
            ListBoxDemoHelper.SelectionMode = ListEditSelectionMode.CheckColumn;
            ListBoxDemoHelper.EnableSelectAll = true;
            return DemoView("ListBox", ListBoxDemoHelper.GetFeatures());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ListBox(ListEditSelectionMode selectionMode, bool enableSelectAll = false) {
            ListBoxDemoHelper.ResetFiltration();
            ListBoxDemoHelper.SelectionMode = selectionMode;
            ListBoxDemoHelper.EnableSelectAll = enableSelectAll;
            return DemoView("ListBox", ListBoxDemoHelper.GetFeatures());
        }
        public ActionResult ListBoxPartial(string selectedFeatures) {
            if(!string.IsNullOrEmpty(selectedFeatures))
                ListBoxDemoHelper.FilterModels(selectedFeatures.Split(','));
            else 
                ListBoxDemoHelper.ResetFiltration();
            return PartialView("ListBoxPartial", ListBoxDemoHelper.GetModels());
        }
    }
}
