using System.Web.Mvc;

namespace DevExpress.Web.Demos
{
    public partial class FeaturesController : DemoController
    {
        public ActionResult AlternativeWeekView()
        {
            return DemoView("AlternativeWeekView", SchedulerDataHelper.DataObject);
        }
        public ActionResult AlternativeWeekViewPartial()
        {
            return PartialView("AlternativeWeekViewPartial", SchedulerDataHelper.DataObject);
        }
    }
}
