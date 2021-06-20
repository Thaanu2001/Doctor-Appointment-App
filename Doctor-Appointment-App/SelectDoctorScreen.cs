using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Doctor_Appointment_App
{
    public partial class SelectDoctorScreen : Form
    {
        private String username;
        private String firstName;
        private Image profileImage;
        private String category;

        public SelectDoctorScreen()
        {
            InitializeComponent();
        }

        public void setUserData(String usrName, String fName, Image profileImg)
        {
            this.username = usrName;
            this.firstName = fName;
            this.profileImage = profileImg;
        }

        public String getCategory()
        {
            return category;
        }

        public void setCategory(String cate)
        {
            this.category = cate;
        }

        private void btnCate_MouseEnter(object sender, EventArgs e)
        {
            btnCate.Image = Doctor_Appointment_App.Properties.Resources.sidebar_button_1_hover;
        }
        private void btnCate_MouseLeave(object sender, EventArgs e)
        {
            btnCate.Image = Doctor_Appointment_App.Properties.Resources.sidebar_button_1;
        }
        private void btnChannels_MouseEnter(object sender, EventArgs e)
        {
            btnChannels.Image = Doctor_Appointment_App.Properties.Resources.sidebar_button_2_hover;
        }
        private void btnChannels_MouseLeave(object sender, EventArgs e)
        {
            btnChannels.Image = Doctor_Appointment_App.Properties.Resources.sidebar_button_2;
        }
        private void btnAbout_MouseEnter(object sender, EventArgs e)
        {
            btnAbout.Image = Doctor_Appointment_App.Properties.Resources.sidebar_button_3_hover;
        }
        private void btnAbout_MouseLeave(object sender, EventArgs e)
        {
            btnAbout.Image = Doctor_Appointment_App.Properties.Resources.sidebar_button_3;
        }
        private void signOut_MouseEnter(object sender, EventArgs e)
        {
            btnSignOut.Image = Doctor_Appointment_App.Properties.Resources.sidebar_button_4_hover;
        }
        private void signOut_MouseLeave(object sender, EventArgs e)
        {
            btnSignOut.Image = Doctor_Appointment_App.Properties.Resources.sidebar_button_4;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

        }
        private void SelectDoctorScreen_Load(object sender, EventArgs e)
        {
            profileImg.Image = profileImage;
            nameLabel.Text = firstName;
            categoryLabel.Text = getCategory();
        }

        private void btnCate_Click(object sender, EventArgs e)
        {
            this.Hide();
            var categoryScreen = new Form1();
            categoryScreen.Closed += (s, args) => this.Close();
            categoryScreen.Show();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            var signinScreen = new signInScreen();
            signinScreen.Closed += (s, args) => this.Close();
            signinScreen.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var categoryScreen = new Form1();
            categoryScreen.Closed += (s, args) => this.Close();
            categoryScreen.Show();
        }
    }
}
