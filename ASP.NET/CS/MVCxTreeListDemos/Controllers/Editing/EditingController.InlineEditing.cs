using System;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditingController : DemoController {
        public ActionResult InlineEditing() {
            return DemoView("InlineEditing", NewsGroupsProvider.GetEditablePosts());
        }
        [ValidateInput(false)]
        public ActionResult InlineEditingPartial() {
            return PartialView("InlineEditingPartial", NewsGroupsProvider.GetEditablePosts());
        }

        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult InlineEditingAddNewPostPartial([Bind] EditablePost post) {
            if (ModelState.IsValid)
                SafeExecute(() => NewsGroupsProvider.InsertPost(post));
            else
                ViewData["EditNodeError"] = "Please, correct all errors.";
            return InlineEditingPartial();
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult InlineEditingUpdatePostPartial([Bind] EditablePost post) {
            if (ModelState.IsValid)
                SafeExecute(() => NewsGroupsProvider.UpdatePost(post));
            else
                ViewData["EditNodeError"] = "Please, correct all errors.";
            return InlineEditingPartial();
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult InlineEditingMovePostPartial(int postID, int? parentID) {
            NewsGroupsProvider.MovePost(postID, parentID);
            return InlineEditingPartial();
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult InlineEditingDeletePostPartial(int postID) {
            SafeExecute(() => NewsGroupsProvider.DeletePost(postID));
            return InlineEditingPartial();
        }
    }
}
