using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditingController : DemoController {
        public ActionResult BatchEditing(BatchEditingDemoOptions options) {
            ViewBag.BatchEditingOptions = options;
            return DemoView("BatchEditing", NewsGroupsProvider.GetEditablePosts());
        }
        [ValidateInput(false)]
        public ActionResult BatchEditingPartial(BatchEditingDemoOptions options) {
            ViewBag.BatchEditingOptions = options;
            return PartialView("BatchEditingPartial", NewsGroupsProvider.GetEditablePosts());
        }

        [ValidateInput(false)]
        public ActionResult BatchEditingUpdateModel(MVCxTreeListBatchUpdateValues<EditablePost, int> updateValues, BatchEditingDemoOptions options) {
            foreach (var newNode in updateValues.InsertNodes) {
                InsertNodesRecursive(newNode, null, updateValues);
            }
            foreach (var post in updateValues.Update) {
                if (updateValues.IsValid(post))
                    UpdatePost(post, updateValues);
            }
            foreach (var postID in updateValues.DeleteKeys) {
                DeletePost(postID, updateValues);
            }
            return BatchEditingPartial(options);
        }
        protected void InsertNodesRecursive(MVCxTreeListNodeInfo<EditablePost> node, int? parentKey, MVCxTreeListBatchUpdateValues<EditablePost, int> updateValues) {
            if (updateValues.IsValid(node.DataItem)) {
                try {
                    if (!node.DataItem.ParentID.HasValue)
                        node.DataItem.ParentID = parentKey;
                    NewsGroupsProvider.InsertPost(node.DataItem);
                    updateValues.SetInsertedNodeKey(node, node.DataItem.PostID);
                    foreach (var childNode in node.ChildNodes) {
                        InsertNodesRecursive(childNode, node.DataItem.PostID, updateValues);
                    }
                } catch (Exception e) {
                    updateValues.SetErrorText(node, e.Message);
                }
            }
        }
        protected void UpdatePost(EditablePost post, MVCxTreeListBatchUpdateValues<EditablePost, int> updateValues) {
            try {
                NewsGroupsProvider.UpdatePost(post);
            } catch (Exception e) {
                updateValues.SetErrorText(post, e.Message);
            }
        }
        protected void DeletePost(int postID, MVCxTreeListBatchUpdateValues<EditablePost, int> updateValues) {
            try {
                NewsGroupsProvider.DeletePost(postID);
            } catch (Exception e) {
                updateValues.SetErrorText(postID, e.Message);
            }
        }
    }
}
