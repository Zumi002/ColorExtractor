using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GK_ColorExtractor.ImageUtils.Converters
{
    //following http://www.brucelindbloom.com/index.html?Eqn_XYZ_to_Lab.html
    static class RGBtoLab
    {
        private const float epsilon = 0.008856f;
        private const float kappa = 903.3f;
        public static (float L, float a, float b) Convert(Color color, ColorSpace cs)
        {
            (float x, float y, float z) = RGBtoXYZ.Convert(color, cs);

            Vector3 norm = new Vector3(x / cs.wp.X,
                                       y / cs.wp.Y,
                                       z / cs.wp.Z);

            Vector3 lab = new Vector3(labFunc(norm.X),
                                      labFunc(norm.Y),
                                      labFunc(norm.Z));

            float L = lab.Y * 116f - 16f;
            float a = (lab.X - lab.Y) * 500f;
            float b = (lab.Y - lab.Z) * 200f;

            return ((float)Math.Clamp(L, 0, 100), (float)Math.Clamp(a,-128,127), (float)Math.Clamp(b,-128,127));
        }

        private static float labFunc(float t)
        {
            if (t > epsilon)
            {
                return (float)Math.Pow(t, 1f / 3f);
            }

            return (kappa * t + 16f) / 116f;
        }
    }
}
