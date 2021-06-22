using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Doctor_Appointment_App
{
    public partial class AboutScreen : Form
    {
        private String username;
        private String firstName;
        private Image profileImage;

        public AboutScreen()
        {
            InitializeComponent();
        }
        public void setUserData(String usrName, String fName, Image profileImg)
        {
            this.username = usrName;
            this.firstName = fName;
            this.profileImage = profileImg;
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
        private void signOut_MouseEnter(object sender, EventArgs e)
        {
            btnSignOut.Image = Doctor_Appointment_App.Properties.Resources.sidebar_button_4_hover;
        }
        private void signOut_MouseLeave(object sender, EventArgs e)
        {
            btnSignOut.Image = Doctor_Appointment_App.Properties.Resources.sidebar_button_4;
        }

        private void AboutScreen_Load(object sender, EventArgs e)
        {
            profileImg.Image = profileImage;
            nameLabel.Text = firstName;
        }

        private void btnCate_Click(object sender, EventArgs e)
        {
            this.Hide();
            var categoryScreen = new Form1();
            categoryScreen.setUsername(username);
            categoryScreen.Closed += (s, args) => this.Close();
            categoryScreen.Show();
        }

        private void btnChannels_Click(object sender, EventArgs e)
        {
            var AppointmentsScreen = new AppointmentsScreen();
            AppointmentsScreen.setUserData(this.username, this.nameLabel.Text, this.profileImg.Image);
            AppointmentsScreen.Show();
            this.Hide();
            AppointmentsScreen.Closed += (s, args) => this.Close();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            var signinScreen = new signInScreen();
            signinScreen.Closed += (s, args) => this.Close();
            signinScreen.Show();
        }
    }
}
