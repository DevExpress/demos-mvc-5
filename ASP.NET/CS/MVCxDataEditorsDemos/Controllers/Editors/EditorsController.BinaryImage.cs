using System.IO;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditorsController: DemoController {
        public ActionResult BinaryImage() {
            return DemoView("BinaryImage", new BinaryImageOptionsModel());
        }

        public ActionResult BinaryImagePartial(BinaryImageOptionsModel optionsModel) {
            var currentSize = optionsModel.AvailableSizes.Find(x => x.ID == optionsModel.ImageSize);
            var binaryImageModel = new BinaryImageModel() {
                ImageSizeMode = optionsModel.ImageSizeMode,
                Height = currentSize.Height,
                Width = currentSize.Width,
                ImageBytes = GetByteArrayFromImage()
            };
            return PartialView("BinaryImagePartial", binaryImageModel);
        }

        protected byte[] GetByteArrayFromImage() {
            const string FileName = @"~\Content\Editors\BinaryImage\Thumbs\people_1200px.jpg";
            using(FileStream stream = new FileStream(Server.MapPath(FileName), FileMode.Open, FileAccess.Read)) {
                byte[] imageInByteArray = new byte[stream.Length];
                stream.Read(imageInByteArray, 0, (int)stream.Length);
                return imageInByteArray;
            }
        }
    }
}
