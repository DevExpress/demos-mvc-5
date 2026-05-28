using System.ComponentModel.DataAnnotations;

namespace DevExpress.Web.Demos {
    public class RibbonOneLineModeDemoOptions {
        public RibbonOneLineModeDemoOptions() {
            OneLineMode = true;
        }
        [Display(Name = "One line mode")]
        public bool OneLineMode { get; set; }
    }
}
