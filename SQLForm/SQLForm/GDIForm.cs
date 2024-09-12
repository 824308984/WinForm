using OpenCvSharp;
using SQLForm.Base;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SQLForm
{
    public partial class GDIForm : Form
    {
        public GDIForm()
        {
            InitializeComponent();
        }

        private void GDIForm_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = e.Graphics;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (opt.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opt.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(opt.FileName.Trim()))
            {
                using (Bitmap bitmap = new Bitmap(opt.FileName))
                {
                    pictureBox1.Image=GDIHelper.ConvertBitmapToSketch(bitmap);
                }
            }
        }

       
    }
}
