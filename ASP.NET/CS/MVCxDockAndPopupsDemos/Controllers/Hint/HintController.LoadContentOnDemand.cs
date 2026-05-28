using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class HintController : DemoController {
        public ActionResult LoadContentOnDemand() {
            return DemoView("LoadContentOnDemand", NorthwindDataProvider.GetEmployees());
        }
        public ActionResult Grid() {
            return PartialView("LoadContentOnDemandPartial", NorthwindDataProvider.GetEmployees());
        }
        public ActionResult Image(int photoId) {
            byte[] image = GetImage(photoId);
            if(image != null) {
                Response.ContentType = "image/jpeg";
                using(MemoryStream ms = new MemoryStream(image))
                    ms.WriteTo(Response.OutputStream);
            }
            return new FileContentResult(image, "image/jpeg");
        }

        byte[] GetImage(int id) {
            using(NorthwindContext context = new NorthwindContext()) {
                var employee = context.Employees.Single(em => em.EmployeeID == id);
                return employee.Photo;
            }
        }
    }
}
