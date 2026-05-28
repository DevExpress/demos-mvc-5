using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DevExpress.Web.ASPxHtmlEditor;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {

    public class ValidationDemoModel {

        public const int MaxLength = 50;
        public const string MaxLengthErrorMessage = "Custom validation fails because the HTML content's length exceeds 50 characters.";

        [Required]
        [HtmlSettings(AllowScripts = false, ResourcePathMode = ResourcePathMode.RootRelative, AllowedDocumentType = AllowedDocumentType.HTML5)]
        public string DemoHtml { get; set; }
    }

    public class ValidationDemoBinder : DevExpressEditorsBinder {
        public ValidationDemoBinder() {
            HtmlEditorBinderSettings.ValidationHandler = (s, e) => {
                if(e.Html.Length > ValidationDemoModel.MaxLength) {
                    e.IsValid = false;
                    e.ErrorText = ValidationDemoModel.MaxLengthErrorMessage;
                }
            };
        }
    }
}
