using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PagingAndScrollingController : DemoController {
        [HttpGet]
        public ActionResult EndlessPaging() {
            return DemoView("EndlessPaging", HomesDataProvider.Homes);
        }
        public ActionResult EndlessPagingPartial(CardViewEndlessPagingMode endlessPagingMode, bool enableScrolling) {
            PagingAndScrollingHelper.Options.EndlessPagingMode = endlessPagingMode;
            PagingAndScrollingHelper.Options.EnableScrolling = enableScrolling;
            return PartialView("EndlessPagingPartial", HomesDataProvider.Homes);
        }
    }
}
