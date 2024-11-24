using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GK_ColorExtractor.ImageUtils.Converters
{
    static class RGBtoXYZ
    {
        public static(float x, float y, float z) Convert(Color color, ColorSpace cs)
        {
            float r = (float)color.R / 255;
            float g = (float)color.G / 255;
            float b = (float)color.B / 255;

            Vector3 linearRGB = new Vector3(
                (float)Math.Pow(r, cs.gamma),
                (float)Math.Pow(g, cs.gamma),
                (float)Math.Pow(b, cs.gamma)
            );

            Vector4 xyz = Vector4.Transform(new Vector4(linearRGB, 0), cs.RGBtoXYZMat);

            return (xyz.X, xyz.Y, xyz.Z);
        }
    }
}
