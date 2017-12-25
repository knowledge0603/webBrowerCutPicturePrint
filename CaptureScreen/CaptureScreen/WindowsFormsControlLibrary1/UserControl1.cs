using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpWin_JD.CaptureImage;

using System.Runtime.InteropServices;

namespace WindowsFormsControlLibrary1
{
    // {A87A771E-0488-45DA-A15C-2B6E512E7E46}
    // {A24FBD8D-E9D0-445B-9612-2D23263D9F16}
    [Guid("A24FBD8D-E9D0-445B-9612-2D23263D9F16")]
    public partial class UserControl1: UserControl , Interface1
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CaptureImageTool capture = new CaptureImageTool();
            //capture.SelectCursor = new Cursor(Properties.Resources.Arrow_M.Handle); 
            if (capture.ShowDialog() == DialogResult.OK)
            {
                Image image = capture.Image;
                pictureBox1.Width = image.Width;
                pictureBox1.Height = image.Height;
                pictureBox1.Image = image;
            }
        }

        public void call()
        {
            CaptureImageTool capture = new CaptureImageTool();
            //capture.SelectCursor = new Cursor(Properties.Resources.Arrow_M.Handle); 
            if (capture.ShowDialog() == DialogResult.OK)
            {
                Image image = capture.Image;
                pictureBox1.Width = image.Width;
                pictureBox1.Height = image.Height;
                pictureBox1.Image = image;
            }
        }
    }
}
