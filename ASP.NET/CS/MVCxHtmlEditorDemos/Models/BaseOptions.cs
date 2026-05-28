using DevExpress.Web.ASPxHtmlEditor;
using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace DevExpress.Web.Demos {
    public abstract class BaseOptions {
        HtmlEditorView? activeView = null;

        public string Html { get; set; }
        public HtmlEditorView ActiveView {
            get { return activeView ?? HtmlEditorExtension.GetActiveView("Html"); }
            set { activeView = value; }
        }

        public void PrepareHtmlEditorSettings(HtmlEditorSettings settings) {
            settings.ActiveView = ActiveView;
            settings.Width = Unit.Percentage(100);
            settings.ClientSideEvents.BeginCallback = "DXDemo.onOptionsDependentControlBeginCallback";
        }
    }
}
