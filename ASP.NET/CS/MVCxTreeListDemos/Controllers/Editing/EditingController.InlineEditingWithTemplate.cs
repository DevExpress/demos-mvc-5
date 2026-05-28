using System;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditingController : DemoController {
        public ActionResult InlineEditingWithTemplate() {
            return DemoView("InlineEditingWithTemplate", NewsGroupsProvider.GetEditablePosts());
        }
        public ActionResult InlineEditingWithTemplatePartial() {
            return PartialView("InlineEditingWithTemplatePartial", NewsGroupsProvider.GetEditablePosts());
        }

        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult InlineEditingWithTemplateAddNewPostPartial([Bind] EditablePost post) {
            if (ModelState.IsValid)
                SafeExecute(() => NewsGroupsProvider.InsertPost(post));
            else
                ViewData["EditNodeError"] = "Please, correct all errors.";
            return InlineEditingWithTemplatePartial();
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult InlineEditingWithTemplateUpdatePostPartial([Bind] EditablePost post) {
            if (ModelState.IsValid)
                SafeExecute(() => NewsGroupsProvider.UpdatePost(post));
            else
                ViewData["EditNodeError"] = "Please, correct all errors.";
            return InlineEditingWithTemplatePartial();
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult InlineEditingWithTemplateMovePostPartial(int postID, int? parentID) {
            NewsGroupsProvider.MovePost(postID, parentID);
            return InlineEditingWithTemplatePartial();
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult InlineEditingWithTemplateDeletePostPartial(int postID) {
            SafeExecute(() => NewsGroupsProvider.DeletePost(postID));
            return InlineEditingWithTemplatePartial();
        }
    }
}
