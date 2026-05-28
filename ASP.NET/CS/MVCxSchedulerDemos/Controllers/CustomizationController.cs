using System.Web.Mvc;
using System;
using DevExpress.Web.ASPxScheduler;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    [ValidateInput(false)]
    public partial class CustomizationController: DemoController {
        public override string Name { get { return "Customization"; } }

        public ActionResult Index() {
            return RedirectToAction("CustomForms");
        }
        public ActionResult MedicalPhoto() {
            if(Request.QueryString[SchedulerDemoHelper.ImageQueryKey] != null) {
                int id = int.Parse(Request.QueryString[SchedulerDemoHelper.ImageQueryKey]);
                Response.ContentType = "image";
                var photo = MedicsSchedulingDataProvider.GetMedicalPhotoById(id);
                if(photo != null)
                    Response.BinaryWrite(photo.ToArray());
                Response.End();
            }
            return null;
        }
    }
}
