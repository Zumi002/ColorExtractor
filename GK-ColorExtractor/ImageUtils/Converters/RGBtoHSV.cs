using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK_ColorExtractor.ImageUtils.Converters
{
    static class RGBtoHSV
    {
        public static (float hue, float sat, float val)Convert(Color color)
        {
            double r = color.R / 255f;
            double g = color.G / 255f;
            double b = color.B / 255f;

            double mMax = Math.Max(Math.Max(r, g), b);
            double mMin = Math.Min(Math.Min(r, g), b);
            double delta = mMax - mMin;

            double hue = 0;
            if (delta != 0)
            {
                if (mMax == r)
                {
                    hue = 60*((g - b) / delta);
                }
                else if (mMax == g)
                {
                    hue = 60*((b - r) / delta + 2);
                }
                else
                {
                    hue = 60*((r - g) / delta + 4);
                }

                if (hue < 0)
                    hue += 360;
            }

            double saturation = (mMax == 0) ? 0 : delta / mMax;

            return ((float)hue, (float)saturation, (float)mMax);
        }
    }
}
