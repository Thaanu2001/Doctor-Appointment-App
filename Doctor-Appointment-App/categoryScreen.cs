using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Doctor_Appointment_App
{
    public partial class Form1 : Form
    {
        private String username;

        public Form1()
        {
            InitializeComponent();
        }

        public String getUsername()
        {
            return username;
        }

        public void setUsername(String usrName)
        {
            this.username = usrName;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var signinScreen = new signInScreen();
            signinScreen.Closed += (s, args) => this.Close();
            signinScreen.Show();
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
        private void btnCat1_MouseEnter(object sender, EventArgs e)
        {
            btnCat1.Image = Doctor_Appointment_App.Properties.Resources.cat_1_hover;
        }
        private void btnCat1_MouseLeave(object sender, EventArgs e)
        {
            btnCat1.Image = Doctor_Appointment_App.Properties.Resources.cat_1;
        }
        private void btnCat2_MouseEnter(object sender, EventArgs e)
        {
            btnCat2.Image = Doctor_Appointment_App.Properties.Resources.cat_2_hover;
        }
        private void btnCat2_MouseLeave(object sender, EventArgs e)
        {
            btnCat2.Image = Doctor_Appointment_App.Properties.Resources.cat_2;
        }
        private void btnCat3_MouseEnter(object sender, EventArgs e)
        {
            btnCat3.Image = Doctor_Appointment_App.Properties.Resources.cat_3_hover;
        }
        private void btnCat3_MouseLeave(object sender, EventArgs e)
        {
            btnCat3.Image = Doctor_Appointment_App.Properties.Resources.cat_3;
        }
        private void btnCat4_MouseEnter(object sender, EventArgs e)
        {
            btnCat4.Image = Doctor_Appointment_App.Properties.Resources.cat_4_hover;
        }
        private void btnCat4_MouseLeave(object sender, EventArgs e)
        {
            btnCat4.Image = Doctor_Appointment_App.Properties.Resources.cat_4;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(Global.getConnectionString());

            //string oString = "select profileImg,firstName from userTable where username='"+getUsername()+"'";
            string oString = "select profileImg,firstName from userTable where username='" + "Thaanu" + "'";
            SqlCommand oCmd = new SqlCommand(oString, myConnection);

            SqlDataAdapter dp = new SqlDataAdapter(oCmd);

            DataSet ds = new DataSet("MyImages");

            byte[] MyData = new byte[0];

            dp.Fill(ds, "MyImages");
            DataRow myRow;
            myRow = ds.Tables["MyImages"].Rows[0];

            MyData = (byte[])myRow["profileImg"];
            nameLabel.Text = (String)myRow["firstName"];

            MemoryStream stream = new MemoryStream(MyData);
            //With the code below, you are in fact converting the byte array of image
            //to the real image.
            profileImg.Image = Image.FromStream(stream);
        }

        private void btnCat1_Click(object sender, EventArgs e)
        {
            var SelectDoctorScreen = new SelectDoctorScreen();
            SelectDoctorScreen.setUserData(this.getUsername(), this.nameLabel.Text, this.profileImg.Image);
            SelectDoctorScreen.setCategory("Psychiatrist");
            SelectDoctorScreen.Show();
            this.Hide();
            SelectDoctorScreen.Closed += (s, args) => this.Close();
        }

        private void btnCat2_Click(object sender, EventArgs e)
        {
            var SelectDoctorScreen = new SelectDoctorScreen();
            SelectDoctorScreen.setUserData(this.getUsername(), this.nameLabel.Text, this.profileImg.Image);
            SelectDoctorScreen.setCategory("Neurosurgeon");
            SelectDoctorScreen.Show();
            this.Hide();
            SelectDoctorScreen.Closed += (s, args) => this.Close();
        }

        private void btnCat3_Click(object sender, EventArgs e)
        {
            var SelectDoctorScreen = new SelectDoctorScreen();
            SelectDoctorScreen.setUserData(this.getUsername(), this.nameLabel.Text, this.profileImg.Image);
            SelectDoctorScreen.setCategory("Cardiologist");
            SelectDoctorScreen.Show();
            this.Hide();
            SelectDoctorScreen.Closed += (s, args) => this.Close();
        }

        private void btnCat4_Click(object sender, EventArgs e)
        {
            var SelectDoctorScreen = new SelectDoctorScreen();
            SelectDoctorScreen.setUserData(this.getUsername(), this.nameLabel.Text, this.profileImg.Image);
            SelectDoctorScreen.setCategory("Pediatrician");
            SelectDoctorScreen.Show();
            this.Hide();
            SelectDoctorScreen.Closed += (s, args) => this.Close();
        }

        private void btnChannels_Click(object sender, EventArgs e)
        {
            var AppointmentsScreen = new AppointmentsScreen();
            AppointmentsScreen.setUserData(this.getUsername(), this.nameLabel.Text, this.profileImg.Image);
            AppointmentsScreen.Show();
            this.Hide();
            AppointmentsScreen.Closed += (s, args) => this.Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            var AboutScreen = new AboutScreen();
            AboutScreen.setUserData(this.getUsername(), this.nameLabel.Text, this.profileImg.Image);
            AboutScreen.Show();
            this.Hide();
            AboutScreen.Closed += (s, args) => this.Close();
        }
    }
}
