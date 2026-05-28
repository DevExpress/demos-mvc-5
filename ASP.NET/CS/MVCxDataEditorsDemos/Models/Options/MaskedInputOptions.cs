using System;

namespace DevExpress.Web.Demos {
    public class MaskedInputOptions {
        public MaskedInputOptions() {
            PromptChar = '_';
            EditFormatString = "MMMM dd, yyyy";
            DateEditValue = DateTime.Now;
        }
        public char PromptChar { get; set; }
        public string EditFormatString { get; set; }
        public DateTime DateEditValue { get; set; }
    }
}
