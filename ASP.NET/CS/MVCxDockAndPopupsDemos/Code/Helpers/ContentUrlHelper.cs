using System;
using System.Web.UI.WebControls;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public class ContentUrlDemoHelper {
        static Action<TextBoxSettings> textBoxSettingsMethod;
        static Action<MemoSettings> memoSettingsMethod;

        public static Action<TextBoxSettings> TextBoxSettingsMethod {
            get {
                if(textBoxSettingsMethod == null)
                    textBoxSettingsMethod = CreateTextBoxSettingsMethod();
                return textBoxSettingsMethod;
            }
        }
        public static Action<MemoSettings> MemoSettingsMethod {
            get {
                if(memoSettingsMethod == null)
                    memoSettingsMethod = CreateMemoSettingsMethod();
                return memoSettingsMethod;
            }
        }
        static Action<TextBoxSettings> CreateTextBoxSettingsMethod() {
            return settings => {
                settings.Width = Unit.Percentage(100);
                settings.ControlStyle.CssClass = "editor";
                settings.ShowModelErrors = true;
                settings.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                settings.Properties.ValidationSettings.ErrorTextPosition = ErrorTextPosition.Left;
            };
        }
        static Action<MemoSettings> CreateMemoSettingsMethod() {
            return settings => {
                settings.Width = Unit.Percentage(100);
                settings.Height = Unit.Percentage(100);
                settings.ControlStyle.CssClass = "editor";
                settings.ShowModelErrors = true;
                settings.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithTooltip;
                settings.Properties.ValidationSettings.ErrorTextPosition = ErrorTextPosition.Left;
            };
        }
    }
}
