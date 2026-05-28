using System;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PopupControlController : DemoController {
        public ActionResult AdaptiveLayout() {
            return DemoView("AdaptiveLayout");
        }
        public ActionResult AdaptiveLayoutPage() {
            return View("AdaptiveLayoutPage", new FormLayoutAdaptiveLayout() {
                FirstName = "Nancy",
                LastName = "Davolio",
                BirthDate = new DateTime(1948, 12, 8),
                Country = "Austria",
                City = "Graz",
                Address = "Kirchgasse 6",
                Notes = "Nancy received a BA degree in psychology from Colorado State University in 2000. She also completed 'The Art of the Cold Call' course. She is a member of Toastmasters International."
            });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdaptiveLayoutPage([Bind] FormLayoutAdaptiveLayout model) {
            return View("AdaptiveLayoutPage", model);
        }
    }
}
