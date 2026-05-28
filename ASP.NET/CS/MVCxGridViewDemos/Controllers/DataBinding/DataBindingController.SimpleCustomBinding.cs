using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DataBindingController: DemoController {
        public ActionResult SimpleCustomBinding() {
            return DemoView("SimpleCustomBinding");
        }
        public ActionResult SimpleCustomBindingPartial() {
            var viewModel = GridViewExtension.GetViewModel("gridView");
            if(viewModel == null)
                viewModel = CreateGridViewModel();
            return SimpleCustomBindingCore(viewModel);
        }
        //Paging
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SimpleCustomBindingPagingAction(GridViewPagerState pager) {
            var viewModel = GridViewExtension.GetViewModel("gridView");
            viewModel.ApplyPagingState(pager);
            return SimpleCustomBindingCore(viewModel);
        }
        //Sorting
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SimpleCustomBindingSortingAction(GridViewColumnState column, bool reset) {
            var viewModel = GridViewExtension.GetViewModel("gridView");
            viewModel.ApplySortingState(column, reset);
            return SimpleCustomBindingCore(viewModel);
        }

        PartialViewResult SimpleCustomBindingCore(GridViewModel gridViewModel) {
            gridViewModel.ProcessCustomBinding(
                GridViewCustomBindingHandlers.GetDataRowCountSimple,
                GridViewCustomBindingHandlers.GetDataSimple
            );
            return PartialView("SimpleCustomBindingPartial", gridViewModel);
        }

        static GridViewModel CreateGridViewModel() {
            var viewModel = new GridViewModel();
            viewModel.KeyFieldName = "ID";
            viewModel.Columns.Add("From");
            viewModel.Columns.Add("Subject");
            viewModel.Columns.Add("Sent");
            viewModel.Columns.Add("Size");
            viewModel.Columns.Add("HasAttachment");
            return viewModel;
        }
    }
}
