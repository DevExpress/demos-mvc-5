using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class RowsController : DemoController {
        public ActionResult FocusedRow() {
            return DemoView("FocusedRow", NorthwindDataProvider.GetEmployees());
        }
        public ActionResult FocusedRowPartial() {
            return PartialView("FocusedRowPartial", NorthwindDataProvider.GetEmployees());
        }
        public ActionResult EmployeeImage() {
            if(Request.QueryString[GridViewRowsDemosHelper.ImageQueryKey] != null) {
                int employeeId = int.Parse(Request.QueryString[GridViewRowsDemosHelper.ImageQueryKey]);
                Response.ContentType = "image";
                var photo = NorthwindDataProvider.GetEmployeePhoto(employeeId);
                if(photo != null)
                    Response.BinaryWrite(photo.ToArray());
                Response.End();
            }
            return null;
        }
    }
}
