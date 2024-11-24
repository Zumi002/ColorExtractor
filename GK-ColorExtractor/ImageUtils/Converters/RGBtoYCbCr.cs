using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK_ColorExtractor.ImageUtils.Converters
{
    static class RGBtoYCbCr
    {
        public static (float Y,float Cb, float Cr)Convert(Color color)
        {
            float r = color.R / 255f;
            float g = color.G / 255f;
            float b = color.B / 255f;

            float yValue = 0.299f * r + 0.587f * g + 0.114f * b;
            float cbValue = (b - yValue) / 1.772f + 0.5f;
            float crValue = (r - yValue) / 1.402f + 0.5f;

            return (yValue, cbValue, crValue);
        }
    }
}
