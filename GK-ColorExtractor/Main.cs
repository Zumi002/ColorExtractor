using GK_ColorExtractor.ImageUtils;
using System.Numerics;
using System.Web;

namespace GK_ColorExtractor
{
    public partial class Main : Form
    {
        DirectBitmap main;
        DirectBitmap left, mid, right;
        Extractor ex;
        DirectBitmap[] oldImages = null;
        int option;

        (Vector2 wp, string name)[] WPPresets =
        {
            (new Vector2(0.31272f,0.32903f), "D65"),
            (new Vector2(0.34567f,0.35850f), "D50")
        };

        (ColorSpace cs, string name, string ilName)[] presets = {
            (new ColorSpace(0.64f, 0.33f, 0.30f, 0.60f, 0.15f, 0.06f, 0.31272f, 0.32903f, 2.2f), "sRGB", "D65"),
            (new ColorSpace(0.64f, 0.33f, 0.21f, 0.71f, 0.15f, 0.06f, 0.31272f, 0.32903f, 2.2f), "AdobeRGB", "D65"),
            (new ColorSpace(0.7347f, 0.2653f, 0.1152f, 0.8264f, 0.1566f, 0.0177f, 0.34567f, 0.35850f, 2.2f), "Wide Gamut" ,"D50")
        };

        public Main()
        {
            ex = new Extractor();
            InitializeComponent();


            //Extract comboBox setup
            ExtractComboBox.Items.Add("YCrCb");
            ExtractComboBox.Items.Add("HSV");
            ExtractComboBox.Items.Add("Lab");
            ExtractComboBox.SelectedIndex = 0;
            SetLabels("[  ]", "[  ]", "[  ]");

            //ColorSpace comboBox setup
            for (int i = 0; i < presets.Length; i++)
            {
                CSComboBox.Items.Add(presets[i].name);
            }
            CSComboBox.Items.Add("Custom");
            CSComboBox.SelectedIndex = presets.Length;

            //Illuminant comboBox setup
            for (int i = 0; i < WPPresets.Length; i++)
            {
                ILComboBox.Items.Add(WPPresets[i].name);
            }
            ILComboBox.Items.Add("Custom");
            ILComboBox.SelectedIndex = WPPresets.Length;

            //write firt preset on controls
            WriteCsOnControls(presets[0].cs);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LoadImageDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap img = (Bitmap)Image.FromFile(LoadImageDialog.FileName);
                if (main != null)
                {
                    main.Dispose();
                }
                main = new DirectBitmap(img.Width, img.Height);
                main.loadFromBitmap(img);
                img.Dispose();
                if (MainPicture.Image != null)
                {
                    MainPicture.Image.Dispose();
                }
                MainPicture.Image = main.Bitmap;
                ex.ChangeMain(main);
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (main != null)
            {
                (DirectBitmap, DirectBitmap, DirectBitmap) bmps;
                if (ExtractComboBox.SelectedIndex == 0)
                {
                    bmps = ex.GetYCbCr();
                    SetLabels("Y", "Cb", "Cr");
                }
                else if (ExtractComboBox.SelectedIndex == 1)
                {
                    bmps = ex.GetHSV();
                    SetLabels("Hue", "Saturation", "Value");
                }
                else
                {
                    bmps = ex.GetLab(GetCSFromControls());
                    SetLabels("L", "a", "b");
                }
                DisposeImages();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                left = bmps.Item1;
                mid = bmps.Item2;
                right = bmps.Item3;
                PictureBoxLeft.Image = left.Bitmap;
                PictureBoxMid.Image = mid.Bitmap;
                PictureBoxRight.Image = right.Bitmap;
            }
        }

        private void DisposeImages()
        {
            PictureBoxLeft.Image = null;
            PictureBoxMid.Image = null;
            PictureBoxRight.Image = null;
            left?.Dispose();
            mid?.Dispose();
            right?.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            option = ExtractComboBox.SelectedIndex;
        }

        private void SetLabels(string leftText, string midText, string rightText)
        {
            LabelLeft.Text = leftText;
            LabelMid.Text = midText;
            LabelRight.Text = rightText;
        }

        private void CSComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CSComboBox.SelectedIndex == presets.Length)
            {
                PresetToggleControls(true);
            }
            else
            {
                PresetToggleControls(false);
                SelectIlluminantFromPreset(CSComboBox.SelectedIndex);
                WriteCsOnControls(presets[CSComboBox.SelectedIndex].cs);
            }
        }

        private void PresetToggleControls(bool toggle)
        {
            rpx.Enabled = toggle;
            rpy.Enabled = toggle;
            gpx.Enabled = toggle;
            gpy.Enabled = toggle;
            bpx.Enabled = toggle;
            bpy.Enabled = toggle;
            wpx.Enabled = toggle;
            wpy.Enabled = toggle;
            gamma.Enabled = toggle;

            ILComboBox.Enabled = toggle;
        }

        private void WriteCsOnControls(ColorSpace cs)
        {
            rpx.Value = (decimal)cs.RGB[0].X;
            rpy.Value = (decimal)cs.RGB[0].Y;
            gpx.Value = (decimal)cs.RGB[1].X;
            gpy.Value = (decimal)cs.RGB[1].Y;
            bpx.Value = (decimal)cs.RGB[2].X;
            bpy.Value = (decimal)cs.RGB[2].Y;

            wpx.Value = (decimal)cs.wp.X;
            wpy.Value = (decimal)cs.wp.Y;

            gamma.Value = (decimal)cs.gamma;
        }

        private void SelectIlluminantFromPreset(int i)
        {
            ILComboBox.SelectedItem = presets[i].ilName;
        }

        private ColorSpace GetCSFromControls()
        {
            float rx = (float)rpx.Value,
                  ry = (float)rpy.Value,
                  gx = (float)gpx.Value,
                  gy = (float)gpy.Value,
                  bx = (float)bpx.Value,
                  by = (float)bpy.Value,
                  wx = (float)wpx.Value,
                  wy = (float)wpy.Value,
                  gam = (float)gamma.Value;

            return new ColorSpace(rx, ry, gx, gy, bx, by, wx, wy, gam);
        }

        private void ILComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ILComboBox.SelectedIndex == WPPresets.Length)
            {
                ilPresetToggleControls(true);
            }
            else
            {
                ilPresetToggleControls(false);
                WriteIlPresetOnControls(WPPresets[ILComboBox.SelectedIndex].wp);
            }
        }

        private void ilPresetToggleControls(bool toggle)
        {
            wpx.Enabled = toggle;
            wpy.Enabled = toggle;
        }

        private void WriteIlPresetOnControls(Vector2 wp)
        {
            wpx.Value = (decimal)wp.X;
            wpy.Value = (decimal)wp.Y;
        }
    }
}
