using System;

using AppKit;
using Foundation;
using IvanSurzhenko.PureBitmap;
using IvanSurzhenko.PureBitmap.Color;

namespace SampleApp.Mac
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            NSImageView imgV = new NSImageView();

            this.View.AddSubview(imgV);

            imgV.Frame = this.View.Bounds;

            var bmp = new ARGB32WinBitmap(200, 200);

            for (uint i = 0; i < 200; i++)
                for (uint j = 0; j < 200; j++)
                    bmp.PutPixel(i, j, (i > 20 && i < 50) ? ARGB32.Black : ARGB32.White);

            using (var stream = bmp.OutputStream())
            {
                imgV.Image = NSImage.FromStream(stream);
            }

            imgV.ImageScaling = NSImageScale.AxesIndependently;
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
    }
}
