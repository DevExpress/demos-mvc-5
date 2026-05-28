using System.Web.Mvc;
using DevExpress.Data;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DataBindingController: DemoController {
        public ActionResult AdvancedCustomBinding() {
            return DemoView("AdvancedCustomBinding");
        }

        public ActionResult AdvancedCustomBindingPartial() {
            var viewModel = GridViewExtension.GetViewModel("gridView");
            if(viewModel == null)
                viewModel = CreateGridViewModelWithSummary();
            return AdvancedCustomBindingCore(viewModel);
        }
        // Paging
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdvancedCustomBindingPagingAction(GridViewPagerState pager) {
            var viewModel = GridViewExtension.GetViewModel("gridView");
            viewModel.ApplyPagingState(pager);
            return AdvancedCustomBindingCore(viewModel);
        }
        // Filtering
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdvancedCustomBindingFilteringAction(GridViewFilteringState filteringState) {
            var viewModel = GridViewExtension.GetViewModel("gridView");
            viewModel.ApplyFilteringState(filteringState);
            return AdvancedCustomBindingCore(viewModel);
        }
        // Sorting
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdvancedCustomBindingSortingAction(GridViewColumnState column, bool reset) {
            var viewModel = GridViewExtension.GetViewModel("gridView");
            viewModel.ApplySortingState(column, reset);
            return AdvancedCustomBindingCore(viewModel);
        }
        // Grouping
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdvancedCustomBindingGroupingAction(GridViewColumnState column) {
            var viewModel = GridViewExtension.GetViewModel("gridView");
            viewModel.ApplyGroupingState(column);
            return AdvancedCustomBindingCore(viewModel);
        }

        PartialViewResult AdvancedCustomBindingCore(GridViewModel viewModel) {
            viewModel.ProcessCustomBinding(
                GridViewCustomBindingHandlers.GetDataRowCountAdvanced,
                GridViewCustomBindingHandlers.GetDataAdvanced,
                GridViewCustomBindingHandlers.GetSummaryValuesAdvanced,
                GridViewCustomBindingHandlers.GetGroupingInfoAdvanced,
                GridViewCustomBindingHandlers.GetUniqueHeaderFilterValuesAdvanced
            );
            return PartialView("AdvancedCustomBindingPartial", viewModel);
        }

        static GridViewModel CreateGridViewModelWithSummary() {
            var viewModel = new GridViewModel();
            viewModel.KeyFieldName = "ID";
            viewModel.Columns.Add("From");
            viewModel.Columns.Add("Subject");
            viewModel.Columns.Add("Sent");
            viewModel.Columns.Add("Size");
            viewModel.Columns.Add("HasAttachment");

            viewModel.TotalSummary.Add(new GridViewSummaryItemState() { FieldName = "Size", SummaryType = SummaryItemType.Sum });
            viewModel.TotalSummary.Add(new GridViewSummaryItemState() { FieldName = "Subject", SummaryType = SummaryItemType.Count });
            viewModel.GroupSummary.Add(new GridViewSummaryItemState() { FieldName = string.Empty, SummaryType = SummaryItemType.Count });
            return viewModel;
        }
    }
}
