using System;
using System.ComponentModel.DataAnnotations;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public class FormLayoutContactInfo {
        public enum ContactType { Email, Phone, SMS, InstantMessenger, PostalService };
        public class EmailContact {
            [Required]
            [RegularExpression("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*", ErrorMessage = "Email is invalid")]
            public string Email { get; set; }
            [Compare("Email")]
            public string RetypeEmail { get; set; }
        }
        public class PhoneContact {
            [Required(ErrorMessage = "*")]
            [Mask("(999) 000-0000", IncludeLiterals = MaskIncludeLiteralsMode.None, ErrorMessage = "*")]
            public int? Phone { get; set; }
            public string Extension { get; set; }
            [Display(Name = "From")]
            public TimeSpan StartTimeToCall { get; set; }
            [Display(Name = "To")]
            public TimeSpan EndTimeToCall { get; set; }
        }
        public class SMSContact {
            [Required(ErrorMessage = "*")]
            [Display(Name = "Mobile Service Provider")]
            public string Provider { get; set; }
            [Required(ErrorMessage = "*")]
            [Display(Name = "Phone Number")]
            [Mask("(999) 000-0000", IncludeLiterals = MaskIncludeLiteralsMode.None, ErrorMessage = "*")]
            public int? Phone { get; set; }
        }
        public class InstantMessengerContact {
            [Required(ErrorMessage = "*")]
            [Display(Name = "Instant Messenger service")]
            public string ServiceName { get; set; }
            [Required(ErrorMessage = "*")]
            [Display(Name = "Messenger ID")]
            public string MessengerID { get; set; }
        }
        public class PostalServiceContact {
            [Required(ErrorMessage = "*")]
            public string Address { get; set; }
            [Required(ErrorMessage = "*")]
            public string City { get; set; }
            [Required(ErrorMessage = "*")]
            [Display(Name = "Post Code")]
            public int? PostCode { get; set; }
            [Required(ErrorMessage = "*")]
            public string Country { get; set; }
        }

        public FormLayoutContactInfo() {
            Email = new EmailContact();
            Phone = new PhoneContact();
            SMS = new SMSContact();
            InstantMessenger = new InstantMessengerContact();
            PostalService = new PostalServiceContact();
        }

        public ContactType Type { get; set; }
        public EmailContact Email { get; private set; }
        public PhoneContact Phone { get; private set; }
        public SMSContact SMS { get; private set; }
        public InstantMessengerContact InstantMessenger { get; private set; }
        public PostalServiceContact PostalService { get; private set; }
    }
}
