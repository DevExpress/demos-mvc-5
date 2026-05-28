namespace DevExpress.Web.Demos {
    public class PopupMenuOptions {
        public const PopupAction DefaultPopupAction = PopupAction.LeftMouseClick;
        public const PopupHorizontalAlign DefaultPopupHorizontalAlign = PopupHorizontalAlign.OutsideRight;
        public const PopupVerticalAlign DefaultPopupVerticalAlign = PopupVerticalAlign.TopSides;
        public const string DefaultCheckedItemName = "";

        public PopupMenuOptions() {
            PopupAction = DefaultPopupAction;
            HorizontalAlign = DefaultPopupHorizontalAlign;
            VerticalAlign = DefaultPopupVerticalAlign;
            CheckedItemName = DefaultCheckedItemName;
        }

        public PopupAction PopupAction { get; set; }
        public PopupHorizontalAlign HorizontalAlign { get; set; }
        public PopupVerticalAlign VerticalAlign { get; set; }
        public string CheckedItemName { get; set; }
    }
}
