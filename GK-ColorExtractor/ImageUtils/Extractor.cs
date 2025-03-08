using System.Drawing;
using GK_ColorExtractor.ImageUtils.Converters;

namespace GK_ColorExtractor.ImageUtils
{
    class Extractor
    {
        private DirectBitmap bmp;

        public Extractor() { }

        public Extractor(DirectBitmap bmp)
        {
            this.bmp = bmp;
        }

        public void ChangeMain(DirectBitmap bmp)
        {
            if (this.bmp != null)
            {
                this.bmp.Dispose();
            }
            this.bmp = bmp;
        }

        public (DirectBitmap, DirectBitmap, DirectBitmap) GetRGB()
        {
            if (bmp == null)
                return (null, null, null);
            DirectBitmap RBmp = new DirectBitmap(bmp.Width, bmp.Height),
                         GBmp = new DirectBitmap(bmp.Width, bmp.Height),
                         BBmp = new DirectBitmap(bmp.Width, bmp.Height);

            Parallel.For(0, (int)bmp.Width, (x) =>
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color c = bmp.GetPixel(x, y);

                    Color RColor = Color.FromArgb(c.R, 0, 0);
                    RBmp.SetPixel(x, y, RColor);

                    Color GColor = Color.FromArgb(0, c.G, 0);
                    GBmp.SetPixel(x, y, GColor);

                    Color BColor = Color.FromArgb(0, 0, c.B);
                    BBmp.SetPixel(x, y, BColor);
                }
            });

            return (RBmp, GBmp, BBmp);
        }
        public (DirectBitmap, DirectBitmap, DirectBitmap) GetYCbCr()
        {
            if (bmp == null)
                return (null, null, null);
            DirectBitmap yBmp = new DirectBitmap(bmp.Width, bmp.Height),
                         cbBmp = new DirectBitmap(bmp.Width, bmp.Height),
                         crBmp = new DirectBitmap(bmp.Width, bmp.Height);

            Parallel.For(0, (int)bmp.Width, (x) =>
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    (float yVal, float CbVal, float CrVal) = RGBtoYCbCr.Convert(bmp.GetPixel(x, y));

                    byte yByte = (byte)(yVal * 255);
                    byte CbByte = (byte)(CbVal * 255);
                    byte CrByte = (byte)(CrVal * 255);

                    Color yColor = Color.FromArgb(yByte, yByte, yByte);
                    yBmp.SetPixel(x, y, yColor);

                    Color cbColor = Color.FromArgb(127, 255 - CbByte, 0 + CbByte);
                    cbBmp.SetPixel(x, y, cbColor);

                    Color crColor = Color.FromArgb(0 + CrByte, 255 - CrByte, 127);
                    crBmp.SetPixel(x, y, crColor);
                }
            });

            return (yBmp, cbBmp, crBmp);
        }
        public (DirectBitmap, DirectBitmap, DirectBitmap) GetHSV()
        {
            if (bmp == null)
                return (null, null, null);
            DirectBitmap hueBmp = new DirectBitmap(bmp.Width, bmp.Height),
                         satBmp = new DirectBitmap(bmp.Width, bmp.Height),
                         valBmp = new DirectBitmap(bmp.Width, bmp.Height);

            Parallel.For(0, (int)bmp.Width, (x) =>
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    (float hue, float sat, float val) = RGBtoHSV.Convert(bmp.GetPixel(x, y));

                    byte hueByte = (byte)(hue / 360 * 255);
                    byte satByte = (byte)(sat * 255);
                    byte valByte = (byte)(val * 255);

                    Color hueColor = Color.FromArgb(hueByte, hueByte, hueByte);
                    hueBmp.SetPixel(x, y, hueColor);

                    Color satColor = Color.FromArgb(satByte, satByte, satByte);
                    satBmp.SetPixel(x, y, satColor);

                    Color valColor = Color.FromArgb(valByte, valByte, valByte);
                    valBmp.SetPixel(x, y, valColor);
                }
            });

            return (hueBmp, satBmp, valBmp);
        }

        public (DirectBitmap, DirectBitmap, DirectBitmap) GetLab(ColorSpace cs)
        {
            if (bmp == null)
                return (null, null, null);
            DirectBitmap LBmp = new DirectBitmap(bmp.Width, bmp.Height),
                         aBmp = new DirectBitmap(bmp.Width, bmp.Height),
                         bBmp = new DirectBitmap(bmp.Width, bmp.Height);

            Parallel.For(0, (int)bmp.Width, (x) =>
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    (float L, float a, float b) = RGBtoLab.Convert(bmp.GetPixel(x, y), cs);

                    byte LByte = (byte)(L / 100 * 255);
                    byte aByte = (byte)(a + 128);
                    byte bByte = (byte)(b + 128);

                    Color LColor = Color.FromArgb(LByte, LByte, LByte);
                    LBmp.SetPixel(x, y, LColor);

                    Color aColor = Color.FromArgb(aByte, 255 - aByte, 127);
                    aBmp.SetPixel(x, y, aColor);

                    Color bColor = Color.FromArgb(bByte, 127, 255 - bByte);
                    bBmp.SetPixel(x, y, bColor);
                }
            });

            return (LBmp, aBmp, bBmp);
        }

    }
}
