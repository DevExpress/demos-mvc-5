using System.Web.UI.WebControls;
using DevExpress.Web.ASPxRichEdit;

namespace DevExpress.Web.Demos {
    public static class RibbonCustomizationDemoHelper {
        public static RibbonTab GetCustomRibbonTab(bool isExtenernalRibbon) {
            RibbonTab ribbonTab = new RibbonTab("Home");
            if (isExtenernalRibbon)
                ribbonTab.Groups.AddRange(new RibbonGroup[] { GetCommonGroup(), GetFontGroup(isExtenernalRibbon), GetViewGroup() });
            else
                ribbonTab.Groups.AddRange(new RibbonGroup[] { GetCommonGroup(), GetUndoGroup(), GetFontGroup(isExtenernalRibbon), GetPagesGroup(), GetViewGroup() });
            return ribbonTab;
        }

        static RERFileCommonGroup GetCommonGroup() {
            var commonGroup = new RERFileCommonGroup();
            commonGroup.Items.AddRange(new RibbonItemBase[] {
                new RERNewCommand(RibbonItemSize.Small) { Text = "New Document", ToolTip = "Ctrl + N" },
                new RERPrintCommand(RibbonItemSize.Small) { Text = "Print Document", ToolTip = "Ctrl + P" }
            });
            return commonGroup;
        }
        static RERUndoGroup GetUndoGroup() {
            var undoGroup = new RERUndoGroup();
            undoGroup.Items.AddRange(new RibbonItemBase[] {
                new RERUndoCommand(RibbonItemSize.Large) { Text = "Undo", ToolTip = "Ctrl + Z" },
                new RERRedoCommand(RibbonItemSize.Large) { Text = "Redo", ToolTip = "Ctrl + Y" }
            });
            return undoGroup;
        }
        static RERFontGroup GetFontGroup(bool isExtenernalRibbon) {
            var fontGroup = new RERFontGroup() { ShowDialogBoxLauncher = isExtenernalRibbon };
            fontGroup.Items.AddRange(new RibbonItemBase[] { 
                PrepareComboBoxCommand(new RERFontNameCommand()),
                PrepareComboBoxCommand(new RERFontSizeCommand()),    
                new RERFontBoldCommand(RibbonItemSize.Large) { Text = "Bold", ToolTip = "Ctrl + B" }, 
                new RERFontItalicCommand(RibbonItemSize.Large) { Text = "Italic", ToolTip = "Ctrl + I" } 
            });
            return fontGroup;
        }
        static RERComboBoxCommandBase PrepareComboBoxCommand(RERComboBoxCommandBase command) {
            command.FillItems();
            command.PropertiesComboBox.Width = Unit.Pixel(100);
            return command;
        }
        static RERPageMarginsCommand CreateRERPageMarginsCommand() {
            RERPageMarginsCommand result = new RERPageMarginsCommand();
            result.Items.Add(new RERSetNormalSectionPageMarginsCommand());
            result.Items.Add(new RERSetNarrowSectionPageMarginsCommand());
            result.Items.Add(new RERSetModerateSectionPageMarginsCommand());
            result.Items.Add(new RERSetWideSectionPageMarginsCommand());
            result.Items.Add(new RERShowPageMarginsSetupFormCommand());
            return result;
        }
        static RERChangeSectionPageOrientationCommand CreateRERChangeSectionPageOrientationCommand() {
            RERChangeSectionPageOrientationCommand result = new RERChangeSectionPageOrientationCommand();
            result.Items.Add(new RERSetPortraitPageOrientationCommand());
            result.Items.Add(new RERSetLandscapePageOrientationCommand());
            return result;
        }
        static RERChangeSectionPaperKindCommand CreateRERChangeSectionPaperKindCommand() {
            RERChangeSectionPaperKindCommand result = new RERChangeSectionPaperKindCommand();
            result.Items.Add(new RERSectionLetterPaperKind());
            result.Items.Add(new RERSectionLegalPaperKind());
            result.Items.Add(new RERSectionFolioPaperKind());
            result.Items.Add(new RERSectionA4PaperKind());
            result.Items.Add(new RERSectionB5PaperKind());
            result.Items.Add(new RERSectionExecutivePaperKind());
            result.Items.Add(new RERSectionA5PaperKind());
            result.Items.Add(new RERSectionA6PaperKind());
            result.Items.Add(new RERShowPagePaperSetupFormCommand());
            return result;
        }
        static RERPagesGroup GetPagesGroup() {
            var pagesGroup = new RERPagesGroup();
            pagesGroup.Items.Add(new RibbonItemBase[] {
                CreateRERPageMarginsCommand(),
                CreateRERChangeSectionPageOrientationCommand(),
                CreateRERChangeSectionPaperKindCommand()
            });
            return pagesGroup;
        }
        static RERViewGroup GetViewGroup() {
            var viewGroup = new RERViewGroup();
            viewGroup.Items.AddRange(new RibbonItemBase[] {
                new RERToggleShowHorizontalRulerCommand(),
                new RERToggleFullScreenCommand() { ToolTip = "F11" } 
            });
            return viewGroup;
        }
    }
}
