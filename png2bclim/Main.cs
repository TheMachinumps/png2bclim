﻿using System;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using CTR;
using System.Runtime.InteropServices;

namespace png2bclim
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            CB_OutFormat.SelectedIndex = 10; // 9 - RGBA8888
            CB_Shape.SelectedIndex = 0; // 0 - Rectangle (>64)
        }

        #region Flat GUI
        #region Import necessary DLL's
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        #region Minimize Button
        private void minimize_MouseEnter(object sender, EventArgs e)
        {
            minimize.Image = Properties.Resources.minimize_hover;
        }
        private void minimize_MouseLeave(object sender, EventArgs e)
        {
            minimize.Image = Properties.Resources.minimize;
        }
        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Close Button
        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.Image = Properties.Resources.close_hover;
        }
        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.Image = Properties.Resources.close;
        }
        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Grabbable window
        private void windowTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion
        #endregion

        // Drag & Drop
        private void tabMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
        private void tabMain_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (Directory.Exists(files[0])) // allow folder
                files = Directory.GetFiles(files[0], "*.*", SearchOption.TopDirectoryOnly);
            foreach (string f in files)
                openFile(f);
        }        
        private void B_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                openFile(TB_Path.Text = ofd.FileName);
        }
        private void openFile(string path)
        {
            // Handle file
            try
            { 
                if (!File.Exists(path)) throw new Exception("Can only accept files, not folders.");
                PaletteBox.Visible = false;
                TB_Path.Text = path;
                switch (Path.GetExtension(path))
                {
                    case ".png":
                        makeBCLIM(path);
                        break;
                    case ".bclim":
                    case ".bin":
                        makeBMP(path);
                        break;
                }
            } catch (Exception e) { Error(e.ToString()); }
        }

        // File Generation
        public void makeBMP(string path)
        {
            BCLIM.CLIM bclim = BCLIM.analyze(path);
            GB_Details.Visible = true;
            L_Details.Text = String.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}", Environment.NewLine,
                bclim.FileFormat, bclim.Width, bclim.Height, bclim.TileWidth, bclim.TileHeight);

            var img = BCLIM.makeBMP(path, CHK_AutoSavePNG.Checked, !CHK_NoCrop.Checked);
            if (img == null) return;
            showPaletteBox(bclim);
            PB_BCLIM.Image = img;
        }
        public void makeBCLIM(string path)
        {
            byte[] data = BCLIM.getBCLIM(path, CB_OutFormat.Text[0]);

            string fp = Path.GetFileNameWithoutExtension(path);
            fp = fp.Substring(fp.IndexOf('_') + 1) + " " + CB_OutFormat.Text.Substring(4);
            string pp = Path.GetDirectoryName(path);
            string newPath = Path.Combine(pp + "/" + fp + ".bclim");

            var sfd = new SaveFileDialog
            {
                FileName = fp + ".bclim",
                InitialDirectory = pp,
                Filter = "BCLIM File|*.bclim" +
                         "|All Files|*.*"
            };
            bool result;

            if (CHK_AutoSaveBCLIM.Checked)
            {
                result = true;
                sfd.FileName = newPath;
            }
            else
                result = (sfd.ShowDialog() == DialogResult.OK);

            if (CHK_AutoSaveBCLIM.Checked || (result))
                File.WriteAllBytes(sfd.FileName, data);

            if (result)
            {
                PB_BCLIM.Image = new Bitmap(path);
                var bclim = BCLIM.analyze(sfd.FileName);
                showPaletteBox(bclim);
                GB_Details.Visible = true;
                L_Details.Text = String.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}", Environment.NewLine,
                    bclim.FileFormat, bclim.Width, bclim.Height, bclim.TileWidth, bclim.TileHeight);
            }
            
        }
        public void showPaletteBox(BCLIM.CLIM bclim)
        {
            // Palette Box
            PaletteBox.Visible = BitConverter.ToUInt16(bclim.Data, 0) == 2 && bclim.FileFormat == 7;
            if (!PaletteBox.Visible) return;

            int colors = BitConverter.ToUInt16(bclim.Data, 2);
            Color[] ca = new Color[colors];
            for (int i = 0; i < colors; i++)
                ca[i] = BCLIM.DecodeColor(BitConverter.ToUInt16(bclim.Data, 4 + 2 * i), 7);
            Bitmap palette = new Bitmap(ca.Length * 8, 8, PixelFormat.Format32bppArgb);
            for (int x = 0; x < ca.Length * 8; x++)
                for (int y = 0; y < 8; y++) { palette.SetPixel(x, y, ca[x / 8]); }
            PaletteBox.Image = palette; PaletteBox.Visible = true;
        }

        // User Experience
        private void dclickPreview(object sender, EventArgs e)
        {
            PB_BCLIM.BorderStyle = PB_BCLIM.BorderStyle == BorderStyle.FixedSingle ? BorderStyle.None : BorderStyle.FixedSingle;
        }
        private void Error(params string[] lines)
        {
            System.Media.SystemSounds.Exclamation.Play();
            string msg = String.Join(Environment.NewLine + Environment.NewLine, lines);
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            imgBackgroundColour.ShowDialog();
            PB_BCLIM.BackColor = imgBackgroundColour.Color;
        }
    }
}
