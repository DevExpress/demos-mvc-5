using System;
using System.Web.UI;
using DevExpress.Web.ASPxTreeList;

namespace DevExpress.Web.Demos {
    public class TreeListInlineEditingDemoHelper {
        public static EditablePost GetEditedPost(TreeListEditFormTemplateContainer container) {
            return new EditablePost {
                From = (string)DataBinder.Eval(container.DataItem, "From"),
                Subject = (string)DataBinder.Eval(container.DataItem, "Subject"),
                PostDate = (DateTime)(DataBinder.Eval(container.DataItem, "PostDate") ?? new DateTime()),
                Text = (string)DataBinder.Eval(container.DataItem, "Text"),
                HasAttachment = (bool?)DataBinder.Eval(container.DataItem, "HasAttachment"),
                IsNew = (bool?)DataBinder.Eval(container.DataItem, "IsNew")
            };
        }
    }
}
