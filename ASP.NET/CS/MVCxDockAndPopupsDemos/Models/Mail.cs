using System.ComponentModel.DataAnnotations;

namespace DevExpress.Web.Demos {
    public class Mail {
        [Display(Name = "Email:")]
        [Required(ErrorMessage = "Email is required")]
        [RegularExpression("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*", ErrorMessage = "Email is invalid")]
        public string Email { get; set; }

        [Display(Name = "Subject:")]
        [StringLength(50, ErrorMessage = "Must be under 50 characters")]
        public string Subject { get; set; }

        [Display(Name = "Message:")]
        [Required(ErrorMessage = "Message is required")]
        public string Message { get; set; }
    }
}
