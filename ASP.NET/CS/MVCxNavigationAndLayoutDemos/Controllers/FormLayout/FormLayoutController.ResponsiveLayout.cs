using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevExpress.Web.Demos
{
    public partial class FormLayoutController : DemoController {
        public ActionResult ResponsiveLayout() {
            return DemoView("ResponsiveLayout");
        }
        public ActionResult ResponsiveLayoutPage() {
            return View("ResponsiveLayoutPage", new FormLayoutResponsiveLayout() {
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
        public ActionResult ResponsiveLayoutPage([Bind] FormLayoutResponsiveLayout model) {
            return View("ResponsiveLayoutPage", model);
        }
    }
}
