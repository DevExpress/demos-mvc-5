using System.ComponentModel.DataAnnotations;

namespace DevExpress.Web.Demos {
    public class RegistrationFormClientSideAPIModel {
        public RegistrationFormClientSideAPIModel() {
            IsNewUser = true;
            LoginModel = new LoginModel();
            RegisterModel = new RegisterModel();
        }
        public bool IsNewUser { get; set; }
        public LoginModel LoginModel { get; private set; }
        public RegisterModel RegisterModel { get; private set; }
    }
    public class LoginModel {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        bool? rememberMe;
        [Display(Name = "Remember Me")]
        public bool? RememberMe {
            get { return rememberMe ?? false; }
            set { rememberMe = value; }
        }
    }
    public class RegisterModel {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address")]
        [RegularExpression("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*", ErrorMessage = "Email is invalid")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
