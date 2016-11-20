namespace png2bclim
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.B_Open = new System.Windows.Forms.Button();
            this.TB_Path = new System.Windows.Forms.TextBox();
            this.GB_BCLIMOptions = new System.Windows.Forms.GroupBox();
            this.CHK_AutoSaveBCLIM = new System.Windows.Forms.CheckBox();
            this.L_SQREC = new System.Windows.Forms.Label();
            this.CB_Shape = new System.Windows.Forms.ComboBox();
            this.CB_OutFormat = new System.Windows.Forms.ComboBox();
            this.GB_PNGOptions = new System.Windows.Forms.GroupBox();
            this.CHK_NoCrop = new System.Windows.Forms.CheckBox();
            this.CHK_AutoSavePNG = new System.Windows.Forms.CheckBox();
            this.GB_Details = new System.Windows.Forms.GroupBox();
            this.L_Meta = new System.Windows.Forms.Label();
            this.L_Details = new System.Windows.Forms.Label();
            this.border1 = new System.Windows.Forms.Panel();
            this.border2 = new System.Windows.Forms.Panel();
            this.border3 = new System.Windows.Forms.Panel();
            this.border4 = new System.Windows.Forms.Panel();
            this.imgBackgroundColour = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.windowTop = new System.Windows.Forms.Panel();
            this.seperator = new System.Windows.Forms.Panel();
            this.windowTitle = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.windowIcon = new System.Windows.Forms.PictureBox();
            this.PaletteBox = new System.Windows.Forms.PictureBox();
            this.PB_BCLIM = new System.Windows.Forms.PictureBox();
            this.GB_BCLIMOptions.SuspendLayout();
            this.GB_PNGOptions.SuspendLayout();
            this.GB_Details.SuspendLayout();
            this.windowTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaletteBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_BCLIM)).BeginInit();
            this.SuspendLayout();
            // 
            // B_Open
            // 
            this.B_Open.BackColor = System.Drawing.Color.White;
            this.B_Open.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.B_Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Open.Location = new System.Drawing.Point(12, 38);
            this.B_Open.Name = "B_Open";
            this.B_Open.Size = new System.Drawing.Size(75, 23);
            this.B_Open.TabIndex = 2;
            this.B_Open.Text = "Open";
            this.B_Open.UseVisualStyleBackColor = false;
            this.B_Open.Click += new System.EventHandler(this.B_Open_Click);
            // 
            // TB_Path
            // 
            this.TB_Path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.TB_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Path.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Path.Location = new System.Drawing.Point(93, 40);
            this.TB_Path.Name = "TB_Path";
            this.TB_Path.ReadOnly = true;
            this.TB_Path.Size = new System.Drawing.Size(280, 20);
            this.TB_Path.TabIndex = 5;
            // 
            // GB_BCLIMOptions
            // 
            this.GB_BCLIMOptions.Controls.Add(this.CHK_AutoSaveBCLIM);
            this.GB_BCLIMOptions.Controls.Add(this.L_SQREC);
            this.GB_BCLIMOptions.Controls.Add(this.CB_Shape);
            this.GB_BCLIMOptions.Controls.Add(this.CB_OutFormat);
            this.GB_BCLIMOptions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GB_BCLIMOptions.Location = new System.Drawing.Point(12, 71);
            this.GB_BCLIMOptions.Name = "GB_BCLIMOptions";
            this.GB_BCLIMOptions.Size = new System.Drawing.Size(135, 114);
            this.GB_BCLIMOptions.TabIndex = 10;
            this.GB_BCLIMOptions.TabStop = false;
            this.GB_BCLIMOptions.Text = "BCLIM Output Format";
            // 
            // CHK_AutoSaveBCLIM
            // 
            this.CHK_AutoSaveBCLIM.AutoSize = true;
            this.CHK_AutoSaveBCLIM.Location = new System.Drawing.Point(13, 91);
            this.CHK_AutoSaveBCLIM.Name = "CHK_AutoSaveBCLIM";
            this.CHK_AutoSaveBCLIM.Size = new System.Drawing.Size(106, 17);
            this.CHK_AutoSaveBCLIM.TabIndex = 3;
            this.CHK_AutoSaveBCLIM.Text = "Autosave BCLIM";
            this.CHK_AutoSaveBCLIM.UseVisualStyleBackColor = true;
            // 
            // L_SQREC
            // 
            this.L_SQREC.AutoSize = true;
            this.L_SQREC.Location = new System.Drawing.Point(9, 46);
            this.L_SQREC.Name = "L_SQREC";
            this.L_SQREC.Size = new System.Drawing.Size(101, 13);
            this.L_SQREC.TabIndex = 2;
            this.L_SQREC.Text = "Square / Rectangle";
            // 
            // CB_Shape
            // 
            this.CB_Shape.BackColor = System.Drawing.Color.White;
            this.CB_Shape.Cursor = System.Windows.Forms.Cursors.Default;
            this.CB_Shape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Shape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_Shape.FormattingEnabled = true;
            this.CB_Shape.Items.AddRange(new object[] {
            "0 - Rectangle (>64)",
            "1 - Square (Override)"});
            this.CB_Shape.Location = new System.Drawing.Point(7, 62);
            this.CB_Shape.Name = "CB_Shape";
            this.CB_Shape.Size = new System.Drawing.Size(121, 21);
            this.CB_Shape.TabIndex = 1;
            // 
            // CB_OutFormat
            // 
            this.CB_OutFormat.BackColor = System.Drawing.Color.White;
            this.CB_OutFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_OutFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_OutFormat.FormattingEnabled = true;
            this.CB_OutFormat.Items.AddRange(new object[] {
            "0 - L8",
            "1 - A8",
            "2 - LA4",
            "3 - LA8",
            "4 - HILO8",
            "5 - RGB565",
            "6 - RGB8 (24bit)",
            "7 - RGBA5551",
            "X - ColorPalette",
            "8 - RGBA4444",
            "9 - RGBA8888",
            "A - ETC1",
            "B - ETC1A4",
            "C - L4",
            "D - A4"});
            this.CB_OutFormat.Location = new System.Drawing.Point(7, 19);
            this.CB_OutFormat.Name = "CB_OutFormat";
            this.CB_OutFormat.Size = new System.Drawing.Size(121, 21);
            this.CB_OutFormat.TabIndex = 0;
            // 
            // GB_PNGOptions
            // 
            this.GB_PNGOptions.Controls.Add(this.CHK_NoCrop);
            this.GB_PNGOptions.Controls.Add(this.CHK_AutoSavePNG);
            this.GB_PNGOptions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GB_PNGOptions.Location = new System.Drawing.Point(12, 191);
            this.GB_PNGOptions.Name = "GB_PNGOptions";
            this.GB_PNGOptions.Size = new System.Drawing.Size(135, 65);
            this.GB_PNGOptions.TabIndex = 11;
            this.GB_PNGOptions.TabStop = false;
            this.GB_PNGOptions.Text = "PNG Output Options";
            // 
            // CHK_NoCrop
            // 
            this.CHK_NoCrop.AutoSize = true;
            this.CHK_NoCrop.Location = new System.Drawing.Point(13, 42);
            this.CHK_NoCrop.Name = "CHK_NoCrop";
            this.CHK_NoCrop.Size = new System.Drawing.Size(109, 17);
            this.CHK_NoCrop.TabIndex = 1;
            this.CHK_NoCrop.Text = "Don\'t Crop Result";
            this.CHK_NoCrop.UseVisualStyleBackColor = true;
            // 
            // CHK_AutoSavePNG
            // 
            this.CHK_AutoSavePNG.AutoSize = true;
            this.CHK_AutoSavePNG.Location = new System.Drawing.Point(13, 19);
            this.CHK_AutoSavePNG.Name = "CHK_AutoSavePNG";
            this.CHK_AutoSavePNG.Size = new System.Drawing.Size(97, 17);
            this.CHK_AutoSavePNG.TabIndex = 0;
            this.CHK_AutoSavePNG.Text = "Autosave PNG";
            this.CHK_AutoSavePNG.UseVisualStyleBackColor = true;
            // 
            // GB_Details
            // 
            this.GB_Details.Controls.Add(this.L_Meta);
            this.GB_Details.Controls.Add(this.L_Details);
            this.GB_Details.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GB_Details.Location = new System.Drawing.Point(12, 262);
            this.GB_Details.Name = "GB_Details";
            this.GB_Details.Size = new System.Drawing.Size(135, 86);
            this.GB_Details.TabIndex = 29;
            this.GB_Details.TabStop = false;
            this.GB_Details.Text = "Details:";
            this.GB_Details.Visible = false;
            // 
            // L_Meta
            // 
            this.L_Meta.AutoSize = true;
            this.L_Meta.Location = new System.Drawing.Point(6, 16);
            this.L_Meta.Name = "L_Meta";
            this.L_Meta.Size = new System.Drawing.Size(73, 65);
            this.L_Meta.TabIndex = 26;
            this.L_Meta.Text = "FileFormat:\r\nImage Width:\r\nImage Height:\r\nTile Width:\r\nTile Height:";
            this.L_Meta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_Details
            // 
            this.L_Details.AutoSize = true;
            this.L_Details.Location = new System.Drawing.Point(85, 16);
            this.L_Details.Name = "L_Details";
            this.L_Details.Size = new System.Drawing.Size(13, 65);
            this.L_Details.TabIndex = 25;
            this.L_Details.Text = "0\r\n0\r\n0\r\n0\r\n0";
            this.L_Details.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // border1
            // 
            this.border1.BackColor = System.Drawing.Color.Silver;
            this.border1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.border1.Location = new System.Drawing.Point(0, 388);
            this.border1.Name = "border1";
            this.border1.Size = new System.Drawing.Size(385, 1);
            this.border1.TabIndex = 30;
            // 
            // border2
            // 
            this.border2.BackColor = System.Drawing.Color.Silver;
            this.border2.Dock = System.Windows.Forms.DockStyle.Top;
            this.border2.Location = new System.Drawing.Point(0, 0);
            this.border2.Name = "border2";
            this.border2.Size = new System.Drawing.Size(384, 1);
            this.border2.TabIndex = 31;
            // 
            // border3
            // 
            this.border3.BackColor = System.Drawing.Color.Silver;
            this.border3.Dock = System.Windows.Forms.DockStyle.Right;
            this.border3.Location = new System.Drawing.Point(384, 0);
            this.border3.Name = "border3";
            this.border3.Size = new System.Drawing.Size(1, 388);
            this.border3.TabIndex = 32;
            // 
            // border4
            // 
            this.border4.BackColor = System.Drawing.Color.Silver;
            this.border4.Dock = System.Windows.Forms.DockStyle.Left;
            this.border4.Location = new System.Drawing.Point(0, 1);
            this.border4.Name = "border4";
            this.border4.Size = new System.Drawing.Size(1, 387);
            this.border4.TabIndex = 31;
            // 
            // imgBackgroundColour
            // 
            this.imgBackgroundColour.AnyColor = true;
            this.imgBackgroundColour.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Preview BGC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // windowTop
            // 
            this.windowTop.Controls.Add(this.windowIcon);
            this.windowTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.windowTop.Location = new System.Drawing.Point(1, 1);
            this.windowTop.Name = "windowTop";
            this.windowTop.Size = new System.Drawing.Size(383, 26);
            this.windowTop.TabIndex = 34;
            this.windowTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.windowTop_MouseDown);
            // 
            // seperator
            // 
            this.seperator.BackColor = System.Drawing.Color.Silver;
            this.seperator.Dock = System.Windows.Forms.DockStyle.Top;
            this.seperator.Location = new System.Drawing.Point(1, 27);
            this.seperator.Name = "seperator";
            this.seperator.Size = new System.Drawing.Size(383, 1);
            this.seperator.TabIndex = 35;
            // 
            // windowTitle
            // 
            this.windowTitle.AutoSize = true;
            this.windowTitle.Location = new System.Drawing.Point(26, 8);
            this.windowTitle.Name = "windowTitle";
            this.windowTitle.Size = new System.Drawing.Size(55, 13);
            this.windowTitle.TabIndex = 39;
            this.windowTitle.Text = "png2bclim";
            // 
            // minimize
            // 
            this.minimize.Image = global::png2bclim.Properties.Resources.minimize;
            this.minimize.Location = new System.Drawing.Point(339, 4);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(20, 20);
            this.minimize.TabIndex = 38;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            this.minimize.MouseEnter += new System.EventHandler(this.minimize_MouseEnter);
            this.minimize.MouseLeave += new System.EventHandler(this.minimize_MouseLeave);
            // 
            // close
            // 
            this.close.Image = global::png2bclim.Properties.Resources.close;
            this.close.Location = new System.Drawing.Point(361, 4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(20, 20);
            this.close.TabIndex = 37;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // windowIcon
            // 
            this.windowIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.windowIcon.Image = global::png2bclim.Properties.Resources.png2bclim_icon;
            this.windowIcon.Location = new System.Drawing.Point(3, 3);
            this.windowIcon.Name = "windowIcon";
            this.windowIcon.Size = new System.Drawing.Size(20, 20);
            this.windowIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.windowIcon.TabIndex = 40;
            this.windowIcon.TabStop = false;
            // 
            // PaletteBox
            // 
            this.PaletteBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaletteBox.Location = new System.Drawing.Point(153, 66);
            this.PaletteBox.Name = "PaletteBox";
            this.PaletteBox.Size = new System.Drawing.Size(80, 10);
            this.PaletteBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PaletteBox.TabIndex = 28;
            this.PaletteBox.TabStop = false;
            this.PaletteBox.Visible = false;
            // 
            // PB_BCLIM
            // 
            this.PB_BCLIM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.PB_BCLIM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_BCLIM.Location = new System.Drawing.Point(153, 78);
            this.PB_BCLIM.Name = "PB_BCLIM";
            this.PB_BCLIM.Padding = new System.Windows.Forms.Padding(5);
            this.PB_BCLIM.Size = new System.Drawing.Size(64, 64);
            this.PB_BCLIM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PB_BCLIM.TabIndex = 6;
            this.PB_BCLIM.TabStop = false;
            this.PB_BCLIM.DoubleClick += new System.EventHandler(this.dclickPreview);
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(385, 389);
            this.Controls.Add(this.windowTitle);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.close);
            this.Controls.Add(this.seperator);
            this.Controls.Add(this.windowTop);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.border4);
            this.Controls.Add(this.border2);
            this.Controls.Add(this.border3);
            this.Controls.Add(this.border1);
            this.Controls.Add(this.GB_Details);
            this.Controls.Add(this.PaletteBox);
            this.Controls.Add(this.GB_PNGOptions);
            this.Controls.Add(this.GB_BCLIMOptions);
            this.Controls.Add(this.PB_BCLIM);
            this.Controls.Add(this.TB_Path);
            this.Controls.Add(this.B_Open);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "png2bclim";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.tabMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.tabMain_DragEnter);
            this.GB_BCLIMOptions.ResumeLayout(false);
            this.GB_BCLIMOptions.PerformLayout();
            this.GB_PNGOptions.ResumeLayout(false);
            this.GB_PNGOptions.PerformLayout();
            this.GB_Details.ResumeLayout(false);
            this.GB_Details.PerformLayout();
            this.windowTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaletteBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_BCLIM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Open;
        private System.Windows.Forms.TextBox TB_Path;
        private System.Windows.Forms.PictureBox PB_BCLIM;
        private System.Windows.Forms.GroupBox GB_BCLIMOptions;
        private System.Windows.Forms.ComboBox CB_OutFormat;
        private System.Windows.Forms.GroupBox GB_PNGOptions;
        private System.Windows.Forms.CheckBox CHK_NoCrop;
        private System.Windows.Forms.CheckBox CHK_AutoSavePNG;
        private System.Windows.Forms.PictureBox PaletteBox;
        private System.Windows.Forms.GroupBox GB_Details;
        private System.Windows.Forms.Label L_SQREC;
        private System.Windows.Forms.ComboBox CB_Shape;
        private System.Windows.Forms.Label L_Details;
        private System.Windows.Forms.CheckBox CHK_AutoSaveBCLIM;
        private System.Windows.Forms.Label L_Meta;
        private System.Windows.Forms.Panel border1;
        private System.Windows.Forms.Panel border2;
        private System.Windows.Forms.Panel border3;
        private System.Windows.Forms.Panel border4;
        private System.Windows.Forms.ColorDialog imgBackgroundColour;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel windowTop;
        private System.Windows.Forms.Panel seperator;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox windowIcon;
        private System.Windows.Forms.Label windowTitle;
    }
}

