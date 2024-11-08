using System;
using System.Windows.Forms;

namespace Student_Registration_Form
{
    public partial class DisplayForm : Form
    {
        private void pictureBoxDisplay_Click(object sender, EventArgs e)
        {
           
        }
        public DisplayForm(string info, string imagePath)
        {
            InitializeComponent();

            lblInfo.Text = info;

            if (!string.IsNullOrEmpty(imagePath))
            {
                pictureBoxDisplay.ImageLocation = imagePath;
                pictureBoxDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
