using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace DevExpress.Web.Demos {
    public class BinaryImageOptionsModel {
        public BinaryImageOptionsModel() {
            AvailableSizes = BinaryImageDemoDataHelper.GetAvailableSizes();            
        }
        public ImageSizeMode ImageSizeMode { get; set; }
        public int ImageSize { get; set; }
        public List<BinaryImageDemoSize> AvailableSizes { get; set; }
    }
    public class BinaryImageModel {
        public ImageSizeMode ImageSizeMode { get; set; }
        public byte[] ImageBytes { get; set; }
        public Unit Height { get; set; }
        public Unit Width { get; set; }
    }
    public class BinaryImageDemoSize {
        public int ID { get; set; }
        public string Text { get; set; }
        public Unit Width { get; set; }
        public Unit Height { get; set; }
    }  
    public static class BinaryImageDemoDataHelper {
        static List<BinaryImageDemoSize> availableSizes;
        static BinaryImageDemoDataHelper() {
            availableSizes = new List<BinaryImageDemoSize>() {
                new BinaryImageDemoSize() { ID = 0, Text = "640 x 480 px", Width = 640, Height = 480 },
                new BinaryImageDemoSize() { ID = 1, Text = "400 x 400 px", Width = 400, Height = 400 },
                new BinaryImageDemoSize() { ID = 2, Text = "Width = 300 px", Width = 300, Height = 0 }
            };
        }
        public static List<BinaryImageDemoSize> GetAvailableSizes() {
            return availableSizes;
        }
    }
}
