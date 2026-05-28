using System.Web.Mvc;
using DevExpress.Data;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DataBindingAndSummariesController: DemoController {
        public ActionResult CustomBinding() {
            return DemoView("CustomBinding");
        }
        public ActionResult CustomBindingPartial() {
            var viewModel = CardViewExtension.GetViewModel("CardView");
            if(viewModel == null)
                viewModel = CreateCardViewModel();
            return CustomBindingCore(viewModel);
        }
        // Paging
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CustomBindingPagingAction(CardViewPagerState pager) {
            CardViewModel viewModel = CardViewExtension.GetViewModel("CardView");
            viewModel.ApplyPagingState(pager);
            return CustomBindingCore(viewModel);
        }
        // Sorting
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CustomBindingSortingAction(CardViewColumnState column, bool reset) {
            CardViewModel viewModel = CardViewExtension.GetViewModel("CardView");
            viewModel.ApplySortingState(column, reset);
            return CustomBindingCore(viewModel);
        }
        // Filtering
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CustomBindingFilteringAction(CardViewFilteringState filteringState) {
            CardViewModel viewModel = CardViewExtension.GetViewModel("CardView");
            viewModel.ApplyFilteringState(filteringState);
            return CustomBindingCore(viewModel);
        }
        PartialViewResult CustomBindingCore(CardViewModel viewModel) {
            viewModel.ProcessCustomBinding(
                CardViewCustomBindingHandlers.GetDataCardCount,
                CardViewCustomBindingHandlers.GetData,
                CardViewCustomBindingHandlers.GetSummaryValues,
                CardViewCustomBindingHandlers.GetUniqueHeaderFilterValues
            );
            return PartialView("CustomBindingPartial", viewModel);
        }

        static CardViewModel CreateCardViewModel() {
            var viewModel = new CardViewModel();
            viewModel.KeyFieldName = "ID";
            viewModel.Columns.Add("From");
            viewModel.Columns.Add("Subject");
            viewModel.Columns.Add("Sent");
            viewModel.Columns.Add("Size");
            viewModel.Columns.Add("HasAttachment");

            viewModel.TotalSummary.Add(new CardViewSummaryItemState() { FieldName = "Size", SummaryType = SummaryItemType.Sum });
            viewModel.TotalSummary.Add(new CardViewSummaryItemState() { FieldName = "Subject", SummaryType = SummaryItemType.Count });
            return viewModel;
        }
    }
}
