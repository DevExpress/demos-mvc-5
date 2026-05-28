using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditorsController : DemoController {
        public ActionResult DateRangePicker() {
            return DemoView("DateRangePicker", new DateRangePickerModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DateRangePicker([Bind] DateRangePickerModel model) {
            if(Request.Params["Submit"] == null)
                ModelState.Clear();
            else
                ViewBag.SuccessValidation = true;
            return DemoView("DateRangePicker", model);
        }
    }
}
