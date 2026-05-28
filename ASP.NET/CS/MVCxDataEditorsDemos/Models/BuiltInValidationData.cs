using System;

namespace DevExpress.Web.Demos {
    public class BuiltInValidationData {
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Email { get; set; }
        public DateTime? ArrivalDate { get; set; }
    }

    public class BuiltInValidationDemoHelper {
        static ValidationSettings nameValidationSettings;
        public static ValidationSettings NameValidationSettings {
            get {
                if(nameValidationSettings == null) {
                    nameValidationSettings = ValidationSettings.CreateValidationSettings(null);
                    nameValidationSettings.Display = Display.Dynamic;
                    nameValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithText;
                    nameValidationSettings.RequiredField.IsRequired = true;
                    nameValidationSettings.RequiredField.ErrorText = "Name is required";
                    nameValidationSettings.ErrorTextPosition = ErrorTextPosition.Bottom;
                }
                return nameValidationSettings;
            }
        }
        static ValidationSettings ageValidationSettings;
        public static ValidationSettings AgeValidationSettings {
            get {
                if(ageValidationSettings == null) {
                    ageValidationSettings = ValidationSettings.CreateValidationSettings(null);
                    ageValidationSettings.Display = Display.Dynamic;
                    ageValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithText;
                    ageValidationSettings.ErrorText = "Must be between 18 and 100";
                    ageValidationSettings.ErrorTextPosition = ErrorTextPosition.Bottom;
                }
                return ageValidationSettings;
            }
        }
        static ValidationSettings emailValidationSettings;
        public static ValidationSettings EmailValidationSettings {
            get {
                if(emailValidationSettings == null) {
                    emailValidationSettings = ValidationSettings.CreateValidationSettings(null);
                    emailValidationSettings.Display = Display.Dynamic;
                    emailValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithText;
                    emailValidationSettings.RequiredField.IsRequired = true;
                    emailValidationSettings.RequiredField.ErrorText = "Email is required";
                    emailValidationSettings.RegularExpression.ValidationExpression = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
                    emailValidationSettings.RegularExpression.ErrorText = "Email is invalid";
                    emailValidationSettings.ErrorTextPosition = ErrorTextPosition.Bottom;
                    
                }
                return emailValidationSettings;
            }
        }
        static ValidationSettings arrivalDateValidationSettings;
        public static ValidationSettings ArrivalDateValidationSettings {
            get {
                if(arrivalDateValidationSettings == null) {
                    arrivalDateValidationSettings = ValidationSettings.CreateValidationSettings(null);
                    arrivalDateValidationSettings.Display = Display.Dynamic;
                    arrivalDateValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithText;                    
                    arrivalDateValidationSettings.ErrorText = "Arrival date is required";
                    arrivalDateValidationSettings.RequiredField.IsRequired = true;
                    arrivalDateValidationSettings.RequiredField.ErrorText = "";
                    arrivalDateValidationSettings.ErrorTextPosition = ErrorTextPosition.Bottom;                    
                }
                return arrivalDateValidationSettings;
            }
        }

        public static void OnNameValidation(object sender, ValidationEventArgs e) {
            if(e.Value == null) {
                e.IsValid = false;
                return;
            }
            var name = e.Value.ToString();
            if(name == string.Empty)
                e.IsValid = false;
            if(name.Length > 50) {
                e.IsValid = false;
                e.ErrorText = "Must be under 50 characters";
            }
        }
        public static void OnAgeValidation(object sender, ValidationEventArgs e) {
            if(e.Value == null)
                return;
            var age = int.Parse(e.Value.ToString());
            if(age < 18 || age > 100)
                e.IsValid = false;
        }
    }
}
