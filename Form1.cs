using System;
using System.Windows.Forms;

namespace Student_Registration_Form
{
    public partial class Form1 : Form
    {
        private string imagePath;

        public Form1()
        {
            InitializeComponent();
            InitializeComboBoxes();
            btnRegister.Click += btnRegister_Click;
            btnBrowse.Click += btnBrowse_Click;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pictureBoxDisplay_Click(object sender, EventArgs e)
        {
  
        }

        private void InitializeComboBoxes()
        {
            for (int i = 1; i <= 31; i++) cmbDay.Items.Add(i.ToString());
            string[] months = { "January", "February", "March", "April", "May", "June",
                                "July", "August", "September", "October", "November", "December" };
            cmbMonth.Items.AddRange(months);
            int currentYear = DateTime.Now.Year;
            for (int year = currentYear; year >= 1980; year--) cmbYear.Items.Add(year.ToString());
            string[] programs = { "BSIT", "BSCS", "Crim" };
            cmbProgram.Items.AddRange(programs);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string lastName = txtLastName.Text;
            string firstName = txtFirstName.Text;
            string middleName = txtMiddleName.Text;
            string gender = chkMale.Checked ? "Male" : chkFemale.Checked ? "Female" : "Not specified";
            string day = cmbDay.SelectedItem?.ToString() ?? "Day";
            string month = cmbMonth.SelectedItem?.ToString() ?? "Month";
            string year = cmbYear.SelectedItem?.ToString() ?? "Year";
            string dateOfBirth = $"{day}/{month}/{year}";
            string program = cmbProgram.SelectedItem?.ToString() ?? "Not specified";

            string info = $"Last Name: {lastName}\n" +
                          $"First Name: {firstName}\n" +
                          $"Middle Name: {middleName}\n" +
                          $"Gender: {gender}\n" +
                          $"Date of Birth: {dateOfBirth}\n" +
                          $"Program: {program}";

      
            DisplayForm displayForm = new DisplayForm(info, imagePath);
            displayForm.ShowDialog();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openFileDialog.FileName; 
                    pictureBox.ImageLocation = imagePath;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
    }
}
