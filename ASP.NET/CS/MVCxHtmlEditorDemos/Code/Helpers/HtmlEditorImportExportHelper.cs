using System.Web.UI.WebControls;
using DevExpress.Web.ASPxHtmlEditor;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public class HtmlEditorImportExportHelper {
        public static HtmlEditorSettings SetHtmlEditorExportSettings(HtmlEditorSettings settings) {
            settings.Name = "heImportExport";
            settings.CallbackRouteValues = new { Controller = "Features", Action = "ImportExportPartial" };
            settings.ExportRouteValues = new { Controller = "Features", Action = "ExportTo" };
            settings.Width = Unit.Percentage(100);

            var toolbar = settings.Toolbars.Add();
            toolbar.Items.Add(new ToolbarUndoButton());
            toolbar.Items.Add(new ToolbarRedoButton());
            toolbar.Items.Add(new ToolbarBoldButton(true));
            toolbar.Items.Add(new ToolbarItalicButton());
            toolbar.Items.Add(new ToolbarUnderlineButton());
            toolbar.Items.Add(new ToolbarStrikethroughButton());
            toolbar.Items.Add(new ToolbarInsertImageDialogButton(true));
            ToolbarExportDropDownButton saveButton = new ToolbarExportDropDownButton(true);
            saveButton.CreateDefaultItems();
            toolbar.Items.Add(saveButton);

            settings.CssFiles.Add("~/Content/HtmlEditor/DemoCss/Export.css");

            return settings;
        }
    }
}
