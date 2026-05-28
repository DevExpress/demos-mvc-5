using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public class MaskedData {
        [Mask("+1 (999) 000-0000", IncludeLiterals = MaskIncludeLiteralsMode.None, ErrorMessage = "Invalid Phone Number")]
        public string Phone { get; set; }
    }
}
