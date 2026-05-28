using System;
using System.Collections.Generic;
using System.Drawing;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public class ColorEditDemoModel {
        public ColorEditDemoModel() {
            RoundPanelAppearance = new RoundPanelAppearance();
            ColorEditorDemoOptions = new ColorEditorDemoOptions();
        }
        public RoundPanelAppearance RoundPanelAppearance { get; set; }
        public ColorEditorDemoOptions ColorEditorDemoOptions { get; set; }
    }
    public static class ColorEditorDemoHelper {
        const int CountColors = 40;
        public static void SetColorEditSettings(MVCxFormLayoutItem item, ColorEditorDemoOptions model) {
            item.NestedExtension().ColorEdit(color => {
                color.Width = Unit.Percentage(100);
                color.Properties.EnableCustomColors = model.EnableCustomColors;
                color.Properties.ColumnCount = model.ColumnCount;
                color.Properties.Items.Assign(CreatePalette(model.Palettes));
                color.Properties.ClientSideEvents.ValueChanged = "onColorChanged";
            });
        }
        public static List<SelectListItem> GetColumnCountList() {
            List<SelectListItem> listColumnCount = new List<SelectListItem>();
            for(int i = 10; i < 30; i += 5) {
                listColumnCount.Add(new SelectListItem() { Text = i.ToString(), Value = i.ToString() });
            }

            return listColumnCount;
        }
        public static ColorEditItemCollection CreatePalette(Palette typePalette) {
            ColorEditItemCollection palette = new ColorEditItemCollection();

            if(typePalette == Palette.Default)
                palette.CreateDefaultItems(true);
            else {
                int step = 256 / CountColors;

                for(int i = 0; i < CountColors; i++)
                    palette.Add(GetHue(typePalette, i * step));
            }

            return palette;
        }
        static Color GetHue(Palette typePalette, int value) {
            Color color = Color.Empty;
            switch(typePalette) {
                case Palette.Red:
                    color = Color.FromArgb(value, 0, 0);
                    break;
                case Palette.Green:
                    color = Color.FromArgb(0, value, 0);
                    break;
                case Palette.Blue:
                    color = Color.FromArgb(0, 0, value);
                    break;
                case Palette.Gray:
                    color = Color.FromArgb(value, value, value);
                    break;
            }
            return color;
        }        
    }
}
