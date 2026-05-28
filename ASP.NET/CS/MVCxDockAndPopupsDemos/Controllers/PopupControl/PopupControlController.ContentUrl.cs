using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PopupControlController : DemoController {
        public ActionResult ContentUrl() {
            return DemoView("ContentUrl");
        }
        public ActionResult ContentUrlFeedForm() {
            return DemoView("ContentUrlFeedForm", new Mail());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ContentUrlFeedForm([Bind] Mail mail) {
            if(!Request.IsAjaxRequest()) { // Theme changing
                ModelState.Clear();
                return DemoView("ContentUrlFeedForm", mail);
            }
            if(ModelState.IsValid)
                return PartialView("ContentUrlFeedFormSuccessPartial");
            return PartialView("ContentUrlFeedFormPartial", mail);
        }
    }
}
