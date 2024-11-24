using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GK_ColorExtractor.ImageUtils
{
    public class DirectBitmap : IDisposable
    {
        public Bitmap Bitmap { get; private set; }
        public Int32[] Bits { get; private set; }
        public bool Disposed { get; private set; }
        public int Height { get; private set; }
        public int Width { get; private set; }

        protected GCHandle BitsHandle { get; private set; }

        public DirectBitmap(int width, int height)
        {
            Width = width;
            Height = height;
            Bits = new Int32[width * height];
            BitsHandle = GCHandle.Alloc(Bits, GCHandleType.Pinned);
            Bitmap = new Bitmap(width, height, width * 4, PixelFormat.Format32bppPArgb, BitsHandle.AddrOfPinnedObject());
        }

        public DirectBitmap(Bitmap bmp)
        {
            Width = bmp.Width;
            Height = bmp.Height;
            Bits = new Int32[Width * Height];
            BitsHandle = GCHandle.Alloc(Bits, GCHandleType.Pinned);
            Bitmap = new Bitmap(Width, Height, Width * 4, PixelFormat.Format32bppPArgb, BitsHandle.AddrOfPinnedObject());
            loadFromBitmap(bmp);
        }

        public void SetPixel(int x, int y, Color colour)
        {
            if (x < 0 || y < 0 || x > Width || y > Height)
                return;
            int index = x + (y * Width);
            int col = colour.ToArgb();

            Bits[index] = col;
        }

        public Color GetPixel(int x, int y)
        {
            int index = x + (y * Width);
            int col = Bits[index];
            Color result = Color.FromArgb(col);

            return result;
        }

        public void Dispose()
        {
            if (Disposed) return;
            Disposed = true;
            Bitmap.Dispose();
            BitsHandle.Free();
        }

        public void Clear()
        {
            for (int i = 0; i < Bits.Length; i++)
            {
                Bits[i] = 255;
            }
        }

        public void loadFromBitmap(Bitmap bmp)
        {
            
            BitmapData bmpData =
            bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            IntPtr ptr = bmpData.Scan0;

            int bytes = Math.Abs(bmpData.Stride) * Height;
            byte[] argbValues = new byte[bytes];
            Marshal.Copy(ptr, argbValues, 0, bytes);
            
            Parallel.For(0, bmp.Width, (i) =>
            {
                for (int j = 0; j < Height; j++)
                {
                    int offset = (j * Width + i) * 4;
                    SetPixel(i, j, Color.FromArgb(argbValues[offset+3], argbValues[offset+2], argbValues[offset+1], argbValues[offset]));
                }
            });
            bmp.UnlockBits(bmpData);
        }


    }
}
