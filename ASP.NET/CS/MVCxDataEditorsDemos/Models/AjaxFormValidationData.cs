using System.ComponentModel.DataAnnotations;

namespace DevExpress.Web.Demos {
    public enum Gender { Male, Female };
    public class AjaxFormValidationData {
        [Display(Name = "Full Name")]
        [Required]
        public string FullName { get; set; }

        public Gender Gender { get; set; }

        [Required]
        [StringLength(10)]
        public string Login { get; set; }

        [Required]
        [StringLength(10)]
        public string Password { get; set; }
    }
}
