using System.Collections.Generic;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public static class PopupMenuDemoHelper {
        public static List<SelectListItem> GetPopupActions() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = PopupAction.LeftMouseClick.ToString(), Value = PopupAction.LeftMouseClick.ToString(), Selected = true },
                new SelectListItem() { Text = PopupAction.RightMouseClick.ToString(), Value = PopupAction.RightMouseClick.ToString() },
                new SelectListItem() { Text = PopupAction.MouseOver.ToString(), Value = PopupAction.MouseOver.ToString() }   
            };
        }
        public static List<SelectListItem> GetPopupHorizontalAlignOptions() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = PopupHorizontalAlign.NotSet.ToString(), Value = PopupHorizontalAlign.NotSet.ToString() },
                new SelectListItem() { Text = PopupHorizontalAlign.OutsideLeft.ToString(), Value = PopupHorizontalAlign.OutsideLeft.ToString() },
                new SelectListItem() { Text = PopupHorizontalAlign.LeftSides.ToString(), Value = PopupHorizontalAlign.LeftSides.ToString() },
                new SelectListItem() { Text = PopupHorizontalAlign.RightSides.ToString(), Value = PopupHorizontalAlign.RightSides.ToString() },
                new SelectListItem() { Text = PopupHorizontalAlign.OutsideRight.ToString(), Value = PopupHorizontalAlign.OutsideRight.ToString(), Selected = true }
            };
        }
        public static List<SelectListItem> GetPopupVerticalAlignOptions() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = PopupVerticalAlign.NotSet.ToString(), Value = PopupVerticalAlign.NotSet.ToString() },
                new SelectListItem() { Text = PopupVerticalAlign.Above.ToString(), Value = PopupVerticalAlign.Above.ToString() },
                new SelectListItem() { Text = PopupVerticalAlign.TopSides.ToString(), Value = PopupVerticalAlign.TopSides.ToString(), Selected = true },
                new SelectListItem() { Text = PopupVerticalAlign.BottomSides.ToString(), Value = PopupVerticalAlign.BottomSides.ToString() },
                new SelectListItem() { Text = PopupVerticalAlign.Below.ToString(), Value = PopupVerticalAlign.Below.ToString() }
            };
        }
    }
}
