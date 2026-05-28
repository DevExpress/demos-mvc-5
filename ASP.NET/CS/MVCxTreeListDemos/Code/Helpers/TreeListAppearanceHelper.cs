using System.Drawing;

namespace DevExpress.Web.Demos {
    public class TreeListAppearanceDemoHelper {
		static bool IsDarkTheme {
			get { return ASPxWebControl.GlobalTheme == "Office365Dark"; }
		}
		public static Color GetBudgetColor(decimal value) {
			decimal coeff = value / 1000 - 22;
			int a = !IsDarkTheme ? (int)(0.02165M * coeff) : (int)(0.04M * coeff);
			int b = !IsDarkTheme ? (int)(0.09066M * coeff) : 0;
			var gParameter = !IsDarkTheme ? 235 : 140;
			var bParameter = !IsDarkTheme ? 177 : 0;
			return Color.FromArgb(255, gParameter - a, bParameter - b);
		}
    }
}
