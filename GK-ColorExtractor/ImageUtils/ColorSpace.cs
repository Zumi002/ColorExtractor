using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GK_ColorExtractor.ImageUtils
{
    struct ColorSpace
    {
        public Vector4[] RGB = new Vector4[3];//R G B;

        public Vector2 wpOrg;

        public Vector4 wp;

        public float gamma;

        public Matrix4x4 RGBtoXYZMat;

        //following http://www.brucelindbloom.com/index.html?Eqn_RGB_XYZ_Matrix.html
        public ColorSpace(float rx, float ry,
                          float gx, float gy,
                          float bx, float by,
                          float wpx, float wpy,
                          float gam)
        {
            calcVector(0, rx, ry);
            calcVector(1, gx, gy);
            calcVector(2, bx, by);

            gamma = gam;
            wpOrg = new Vector2(wpx, wpy);
            wp = new Vector4(wpx / wpy, 1, (1 - wpx - wpy) / wpy, 0);

            Matrix4x4 chromaMatrix = Matrix4x4.Identity;
            for (int i = 0; i < 3; i++)
            {
                chromaMatrix[i, 0] = RGB[i].X;
                chromaMatrix[i, 1] = RGB[i].Y;
                chromaMatrix[i, 2] = RGB[i].Z;
            }

            Matrix4x4 invChroma;
            Matrix4x4.Invert(chromaMatrix, out invChroma);

            Vector4 S = Vector4.Transform(wp, invChroma);


            for (int i = 0; i < 3; i++)
            {
                chromaMatrix[0, i] *= S.X;
                chromaMatrix[1, i] *= S.Y;
                chromaMatrix[2, i] *= S.Z;
            }
            RGBtoXYZMat = chromaMatrix;
        }
        public ColorSpace(float rx, float ry,
                         float gx, float gy,
                         float bx, float by,
                         Vector2 wp,
                         float gam) : 
        this(rx, ry,
             gx, gy,
             bx, by,
             wp.X, wp.Y,
             gam) { }
        

        private void calcVector(int pos, float x, float y)
        {
            RGB[pos] = new Vector4(x , y, (1 - x - y), 1);
        }

    }
}
