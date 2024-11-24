namespace GK_ColorExtractor
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            LabelRight = new Label();
            LabelMid = new Label();
            PictureBoxLeft = new PictureBox();
            PictureBoxMid = new PictureBox();
            PictureBoxRight = new PictureBox();
            LabelLeft = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            MainPicture = new PictureBox();
            groupBox1 = new GroupBox();
            label9 = new Label();
            groupBox2 = new GroupBox();
            label10 = new Label();
            label8 = new Label();
            ILComboBox = new ComboBox();
            CSComboBox = new ComboBox();
            gamma = new NumericUpDown();
            label7 = new Label();
            wpy = new NumericUpDown();
            bpy = new NumericUpDown();
            wpx = new NumericUpDown();
            label6 = new Label();
            bpx = new NumericUpDown();
            label5 = new Label();
            gpy = new NumericUpDown();
            gpx = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            rpy = new NumericUpDown();
            rpx = new NumericUpDown();
            label1 = new Label();
            ExtractComboBox = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            LoadImageDialog = new OpenFileDialog();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxMid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxRight).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainPicture).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gamma).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wpy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bpy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wpx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bpx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gpy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gpx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rpy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rpx).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 62.6865654F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 37.3134346F));
            tableLayoutPanel1.Size = new Size(878, 600);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(LabelRight, 2, 0);
            tableLayoutPanel2.Controls.Add(LabelMid, 1, 0);
            tableLayoutPanel2.Controls.Add(PictureBoxLeft, 0, 1);
            tableLayoutPanel2.Controls.Add(PictureBoxMid, 1, 1);
            tableLayoutPanel2.Controls.Add(PictureBoxRight, 2, 1);
            tableLayoutPanel2.Controls.Add(LabelLeft, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 379);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(872, 218);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // LabelRight
            // 
            LabelRight.Anchor = AnchorStyles.None;
            LabelRight.AutoSize = true;
            LabelRight.Location = new Point(716, 7);
            LabelRight.Name = "LabelRight";
            LabelRight.Size = new Size(19, 15);
            LabelRight.TabIndex = 5;
            LabelRight.Text = "Cr";
            // 
            // LabelMid
            // 
            LabelMid.Anchor = AnchorStyles.None;
            LabelMid.AutoSize = true;
            LabelMid.Location = new Point(424, 7);
            LabelMid.Name = "LabelMid";
            LabelMid.Size = new Size(22, 15);
            LabelMid.TabIndex = 4;
            LabelMid.Text = "Cb";
            // 
            // PictureBoxLeft
            // 
            PictureBoxLeft.Dock = DockStyle.Fill;
            PictureBoxLeft.Location = new Point(3, 33);
            PictureBoxLeft.Name = "PictureBoxLeft";
            PictureBoxLeft.Size = new Size(284, 182);
            PictureBoxLeft.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxLeft.TabIndex = 0;
            PictureBoxLeft.TabStop = false;
            // 
            // PictureBoxMid
            // 
            PictureBoxMid.Dock = DockStyle.Fill;
            PictureBoxMid.Location = new Point(293, 33);
            PictureBoxMid.Name = "PictureBoxMid";
            PictureBoxMid.Size = new Size(284, 182);
            PictureBoxMid.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxMid.TabIndex = 1;
            PictureBoxMid.TabStop = false;
            // 
            // PictureBoxRight
            // 
            PictureBoxRight.Dock = DockStyle.Fill;
            PictureBoxRight.Location = new Point(583, 33);
            PictureBoxRight.Name = "PictureBoxRight";
            PictureBoxRight.Size = new Size(286, 182);
            PictureBoxRight.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxRight.TabIndex = 2;
            PictureBoxRight.TabStop = false;
            // 
            // LabelLeft
            // 
            LabelLeft.Anchor = AnchorStyles.None;
            LabelLeft.AutoSize = true;
            LabelLeft.Location = new Point(138, 7);
            LabelLeft.Name = "LabelLeft";
            LabelLeft.Size = new Size(14, 15);
            LabelLeft.TabIndex = 3;
            LabelLeft.Text = "Y";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel3.Controls.Add(MainPicture, 0, 0);
            tableLayoutPanel3.Controls.Add(groupBox1, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(872, 370);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // MainPicture
            // 
            MainPicture.Dock = DockStyle.Fill;
            MainPicture.Location = new Point(3, 3);
            MainPicture.Name = "MainPicture";
            MainPicture.Size = new Size(616, 364);
            MainPicture.SizeMode = PictureBoxSizeMode.Zoom;
            MainPicture.TabIndex = 0;
            MainPicture.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(ExtractComboBox);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(625, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(244, 364);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Controls";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 55);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 16;
            label9.Text = "Format:";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom;
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(ILComboBox);
            groupBox2.Controls.Add(CSComboBox);
            groupBox2.Controls.Add(gamma);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(wpy);
            groupBox2.Controls.Add(bpy);
            groupBox2.Controls.Add(wpx);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(bpx);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(gpy);
            groupBox2.Controls.Add(gpx);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(rpy);
            groupBox2.Controls.Add(rpx);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(6, 96);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(234, 262);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lab settings";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 63);
            label10.Name = "label10";
            label10.Size = new Size(104, 15);
            label10.TabIndex = 16;
            label10.Text = "Illuminant presets:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 34);
            label8.Name = "label8";
            label8.Size = new Size(116, 15);
            label8.TabIndex = 15;
            label8.Text = "Color profile presets:";
            // 
            // ILComboBox
            // 
            ILComboBox.FormattingEnabled = true;
            ILComboBox.Location = new Point(131, 60);
            ILComboBox.Name = "ILComboBox";
            ILComboBox.Size = new Size(75, 23);
            ILComboBox.TabIndex = 14;
            ILComboBox.SelectedIndexChanged += ILComboBox_SelectedIndexChanged;
            // 
            // CSComboBox
            // 
            CSComboBox.FormattingEnabled = true;
            CSComboBox.Location = new Point(131, 31);
            CSComboBox.Name = "CSComboBox";
            CSComboBox.Size = new Size(75, 23);
            CSComboBox.TabIndex = 13;
            CSComboBox.SelectedIndexChanged += CSComboBox_SelectedIndexChanged;
            // 
            // gamma
            // 
            gamma.DecimalPlaces = 5;
            gamma.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            gamma.Location = new Point(166, 224);
            gamma.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            gamma.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            gamma.Name = "gamma";
            gamma.Size = new Size(62, 23);
            gamma.TabIndex = 12;
            gamma.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(99, 226);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 11;
            label7.Text = "Gamma:";
            // 
            // wpy
            // 
            wpy.DecimalPlaces = 5;
            wpy.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            wpy.Location = new Point(166, 195);
            wpy.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            wpy.Name = "wpy";
            wpy.Size = new Size(62, 23);
            wpy.TabIndex = 6;
            // 
            // bpy
            // 
            bpy.DecimalPlaces = 5;
            bpy.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            bpy.Location = new Point(166, 166);
            bpy.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            bpy.Name = "bpy";
            bpy.Size = new Size(62, 23);
            bpy.TabIndex = 10;
            // 
            // wpx
            // 
            wpx.DecimalPlaces = 5;
            wpx.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            wpx.Location = new Point(89, 195);
            wpx.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            wpx.Name = "wpx";
            wpx.Size = new Size(62, 23);
            wpx.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 197);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 4;
            label6.Text = "White Point:";
            // 
            // bpx
            // 
            bpx.DecimalPlaces = 5;
            bpx.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            bpx.Location = new Point(89, 166);
            bpx.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            bpx.Name = "bpx";
            bpx.Size = new Size(62, 23);
            bpx.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 168);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 8;
            label5.Text = "Red primary:";
            // 
            // gpy
            // 
            gpy.DecimalPlaces = 5;
            gpy.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            gpy.Location = new Point(166, 137);
            gpy.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            gpy.Name = "gpy";
            gpy.Size = new Size(62, 23);
            gpy.TabIndex = 7;
            // 
            // gpx
            // 
            gpx.DecimalPlaces = 5;
            gpx.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            gpx.Location = new Point(89, 137);
            gpx.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            gpx.Name = "gpx";
            gpx.Size = new Size(62, 23);
            gpx.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 139);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 5;
            label4.Text = "Red primary:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(166, 90);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 4;
            label3.Text = "Y:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 90);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 3;
            label2.Text = "X:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rpy
            // 
            rpy.DecimalPlaces = 5;
            rpy.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            rpy.Location = new Point(166, 108);
            rpy.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            rpy.Name = "rpy";
            rpy.Size = new Size(62, 23);
            rpy.TabIndex = 2;
            // 
            // rpx
            // 
            rpx.DecimalPlaces = 5;
            rpx.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            rpx.Location = new Point(89, 108);
            rpx.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            rpx.Name = "rpx";
            rpx.Size = new Size(62, 23);
            rpx.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 110);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Red primary:";
            // 
            // ExtractComboBox
            // 
            ExtractComboBox.FormattingEnabled = true;
            ExtractComboBox.Location = new Point(6, 73);
            ExtractComboBox.Name = "ExtractComboBox";
            ExtractComboBox.Size = new Size(114, 23);
            ExtractComboBox.TabIndex = 2;
            ExtractComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(126, 73);
            button2.Name = "button2";
            button2.Size = new Size(114, 23);
            button2.TabIndex = 1;
            button2.Text = "Extract";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(6, 22);
            button1.Name = "button1";
            button1.Size = new Size(114, 23);
            button1.TabIndex = 0;
            button1.Text = "Load Image...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LoadImageDialog
            // 
            LoadImageDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF,*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 600);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(894, 600);
            Name = "Main";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxMid).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxRight).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainPicture).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gamma).EndInit();
            ((System.ComponentModel.ISupportInitialize)wpy).EndInit();
            ((System.ComponentModel.ISupportInitialize)bpy).EndInit();
            ((System.ComponentModel.ISupportInitialize)wpx).EndInit();
            ((System.ComponentModel.ISupportInitialize)bpx).EndInit();
            ((System.ComponentModel.ISupportInitialize)gpy).EndInit();
            ((System.ComponentModel.ISupportInitialize)gpx).EndInit();
            ((System.ComponentModel.ISupportInitialize)rpy).EndInit();
            ((System.ComponentModel.ISupportInitialize)rpx).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox PictureBoxLeft;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox MainPicture;
        private PictureBox PictureBoxMid;
        private Label LabelRight;
        private Label LabelMid;
        private PictureBox PictureBoxRight;
        private Label LabelLeft;
        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private OpenFileDialog LoadImageDialog;
        private ComboBox ExtractComboBox;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private NumericUpDown rpy;
        private NumericUpDown rpx;
        private Label label3;
        private NumericUpDown wpy;
        private NumericUpDown bpy;
        private NumericUpDown wpx;
        private Label label6;
        private NumericUpDown bpx;
        private Label label5;
        private NumericUpDown gpy;
        private NumericUpDown gpx;
        private Label label4;
        private NumericUpDown gamma;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label8;
        private ComboBox ILComboBox;
        private ComboBox CSComboBox;
    }
}
