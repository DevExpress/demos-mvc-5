namespace DevExpress.Web.Demos {
    public class TokenBoxOptions {
        public TokenBoxOptions() {
            AllowCustomTokens = true;
            ShowDropDownOnFocus = ShowDropDownOnFocusMode.Always;
            IncrementalFilteringMode = IncrementalFilteringMode.Contains;
        }

        public bool AllowCustomTokens { get; set; }
        public ShowDropDownOnFocusMode ShowDropDownOnFocus { get; set; }
        public IncrementalFilteringMode IncrementalFilteringMode { get; set; }
    }
}
