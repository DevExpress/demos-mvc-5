using System;
using System.Collections;
using System.Linq;
using DevExpress.Spreadsheet;
using DevExpress.Web.ASPxSpreadsheet;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public class ClientSideEventsDemoHelper {
        public static RibbonTab[] GetRibbonTabs() {
            return new RibbonTab[] { GetCustomRibbonTab(), GetReadingViewTab() };
        }

        static RibbonTab GetCustomRibbonTab() {
            RibbonTab ribbonTab = new RibbonTab("Home");
            ribbonTab.Groups.AddRange(new RibbonGroup[] { GetFileCommonGroup(), GetDocumentViewsGroup(), GetViewGroup(), GetCustomRibbonGroup() });
            return ribbonTab;
        }

        static SRFileCommonGroup GetFileCommonGroup() {
            SRFileCommonGroup fileCommonGroup = new SRFileCommonGroup();
            fileCommonGroup.Items.AddRange(new RibbonItemBase[] { new SRFileNewCommand(), new SRFilePrintCommand() });
            return fileCommonGroup;
        }

        static SRDocumentViewsGroup GetDocumentViewsGroup() {
            SRDocumentViewsGroup documentViewsGroup = new SRDocumentViewsGroup();
            documentViewsGroup.Items.AddRange(new RibbonItemBase[] { new SRViewToggleEditingViewCommand(), new SRViewToggleReadingViewCommand() });
            return documentViewsGroup;
        }

        static SRViewGroup GetViewGroup() {
            SRViewGroup viewGroup = new SRViewGroup();
            viewGroup.Items.Add(new SRFullScreenCommand());
            return viewGroup;
        }

        static SRReadingViewTab GetReadingViewTab() {
            SRReadingViewTab ribbonTab = new SRReadingViewTab();
            ribbonTab.Groups.Add(GetReadingViewGroup());
            return ribbonTab;
        }

        static SRReadingViewGroup GetReadingViewGroup() {
            SRReadingViewGroup readingViewGroup = new SRReadingViewGroup();
            readingViewGroup.Items.AddRange(new RibbonItemBase[] { new SRViewToggleEditingViewCommand(), new SRFilePrintCommand(), new SREditingFindAndSelectCommand() });
            return readingViewGroup;
        }

        static RibbonGroup GetCustomRibbonGroup() {
            RibbonGroup ribbonGroup = new RibbonGroup();
            ribbonGroup.Text = "Custom Ribbon Group";
            ribbonGroup.Image.IconID = "scheduling_switchtimescalesto_32x32gray";

            RibbonDropDownButtonItem dropDownItem = CreateButtonItem<RibbonDropDownButtonItem>("CustomDropDownToggleButtons", "Custom DropDown Toggle Buttons", "data_editdatasource_32x32", "data_editdatasource_16x16gray");
            dropDownItem.Items.AddRange(new RibbonDropDownButtonItem[] {
                CreateButtonItem<RibbonDropDownToggleButtonItem>("DropDownToggleButton1", "DropDown Toggle Button 1", RibbonItemSize.Small, "", ""),
                CreateButtonItem<RibbonDropDownToggleButtonItem>("DropDownToggleButton2", "DropDown Toggle Button 2", RibbonItemSize.Small, "actions_apply_16x16", "")
            });
            ribbonGroup.Items.AddRange(new RibbonItemBase[] {
                CreateButtonItem<RibbonOptionButtonItem>("CustomOption", "Custom option", "zoom_zoom2_32x32", "zoom_zoom2_16x16gray"),
                CreateButtonItem<RibbonButtonItem>("CustomButton", "Custom button", "scheduling_switchtimescalesto_32x32", "scheduling_switchtimescalesto_16x16gray"),
                dropDownItem
            });
            return ribbonGroup;
        }

        static T CreateButtonItem<T>(string name, string text, string largeIconID, string smallIconID) where T : RibbonButtonItem {
            return CreateButtonItem<T>(name, text, RibbonItemSize.Large, largeIconID, smallIconID);
        }

        static T CreateButtonItem<T>(string name, string text, RibbonItemSize size, string largeIconID, string smallIconID) where T : RibbonButtonItem {
            var item = Activator.CreateInstance<T>();
            item.Name = name;
            item.Text = text;
            item.Size = size;
            if(size == RibbonItemSize.Small)
                item.SmallImage.IconID = largeIconID;
            else {
                item.LargeImage.IconID = largeIconID;
                item.SmallImage.IconID = smallIconID;
            }
            return item;
        }
    }
}
