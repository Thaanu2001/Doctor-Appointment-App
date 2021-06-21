using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Doctor_Appointment_App
{
    public partial class BookAppointmentScreen : Form
    {
        private String username;
        private String firstName;
        private Image profileImage;
        private String category;
        private String drFullName;
        private String drSpecialty;

        public BookAppointmentScreen()
        {
            InitializeComponent();
        }
        public void setUserData(String usrName, String fName, Image profileImg)
        {
            this.username = usrName;
            this.firstName = fName;
            this.profileImage = profileImg;
        }
        public void setDoctorData(String Name, String Specialty)
        {
            this.drFullName = Name;
            this.drSpecialty = Specialty;
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
        private void btnBook_MouseEnter(object sender, EventArgs e)
        {
            btnBook.Image = Doctor_Appointment_App.Properties.Resources.appointment_btn_hover;
        }
        private void btnBook_MouseLeave(object sender, EventArgs e)
        {
            btnBook.Image = Doctor_Appointment_App.Properties.Resources.appointment_btn;
        }

        private void BookAppointmentScreen_Load(object sender, EventArgs e)
        {
            profileImg.Image = profileImage;
            nameLabel.Text = firstName;
            drName.Text = drFullName;
            drSpeciality.Text = drSpecialty;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var SelectDoctorScreen = new SelectDoctorScreen();
            SelectDoctorScreen.setUserData(this.username, this.nameLabel.Text, this.profileImg.Image);
            SelectDoctorScreen.setCategory(getCategory());
            SelectDoctorScreen.Closed += (s, args) => this.Close();
            SelectDoctorScreen.Show();
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

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (txtPatientName.Text != "") {
                string connetionString;
                string sql;

                connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\GitHub\Repositories\Doctor-Appointment-App\Doctor-Appointment-App\MediCareDB.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection cnn = new SqlConnection(connetionString);

                sql = "Insert into appointmentTable (username, doctorName, doctorSpecialty, patientName, date, time, notes) values ('" + this.username + "','" + this.drFullName + "','" + this.drSpecialty + "','" + this.txtPatientName.Text + "','" + this.txtDate.Text + "','" + this.txtTime.Text + "','" + this.txtNote.Text + "')";
                SqlCommand com = new SqlCommand(sql, cnn);

                cnn.Open();
                com.ExecuteNonQuery();


                this.Hide();
                var categoryScreen = new Form1();
                categoryScreen.Closed += (s, args) => this.Close();
                categoryScreen.Show();
                var AppointmentPlacedPopup = new AppointmentPlacedPopup();
                AppointmentPlacedPopup.Show();
            }
            else
            {
                errMsg.Visible = true;
            }
        }
    }
}
