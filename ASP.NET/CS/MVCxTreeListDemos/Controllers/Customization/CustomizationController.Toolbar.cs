using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class CustomizationController : DemoController {

        public ActionResult Toolbar() {
            return DemoView("Toolbar", NewsGroupsProvider.GetEditablePosts());
        }
        public ActionResult ToolbarPartial() {
            return PartialView("ToolbarPartial", NewsGroupsProvider.GetEditablePosts());
        }

        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult ToolbarAddNewPostPartial([Bind(Include = "PostID,ParentID,Subject,Text,PostDate")]EditablePost post) {
            ModelState.Remove("From");
            if(ModelState.IsValid) {
                SafeExecute(() => {
                    post.From = "DevExpress demo";
                    post.PostDate = DateTime.Now;
                    NewsGroupsProvider.InsertPost(post);
                });
            } else
                ViewBag.EditNodeError = "Please, correct all errors.";
            return ToolbarPartial();
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult ToolbarDeletePostPartial(int postID) {
            SafeExecute(() => NewsGroupsProvider.DeletePost(postID));
            return ToolbarPartial();
        }

        void SafeExecute(Action method) {
            try {
                method();
            } catch (Exception e) {
                ViewBag.EditNodeError = e.Message;
            }
        }
    }
}
