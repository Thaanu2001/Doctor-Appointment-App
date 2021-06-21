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
        private void drButton1_MouseEnter(object sender, EventArgs e)
        {
            drButton1.Image = Doctor_Appointment_App.Properties.Resources.book_appointment_btn_hover;
        }
        private void drButton1_MouseLeave(object sender, EventArgs e)
        {
            drButton1.Image = Doctor_Appointment_App.Properties.Resources.book_appointment_btn;
        }
        private void drButton2_MouseEnter(object sender, EventArgs e)
        {
            drButton2.Image = Doctor_Appointment_App.Properties.Resources.book_appointment_btn_hover;
        }
        private void drButton2_MouseLeave(object sender, EventArgs e)
        {
            drButton2.Image = Doctor_Appointment_App.Properties.Resources.book_appointment_btn;
        }
        private void drButton3_MouseEnter(object sender, EventArgs e)
        {
            drButton3.Image = Doctor_Appointment_App.Properties.Resources.book_appointment_btn_hover;
        }
        private void drButton3_MouseLeave(object sender, EventArgs e)
        {
            drButton3.Image = Doctor_Appointment_App.Properties.Resources.book_appointment_btn;
        }
        private void drButton4_MouseEnter(object sender, EventArgs e)
        {
            drButton4.Image = Doctor_Appointment_App.Properties.Resources.book_appointment_btn_hover;
        }
        private void drButton4_MouseLeave(object sender, EventArgs e)
        {
            drButton4.Image = Doctor_Appointment_App.Properties.Resources.book_appointment_btn;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

        }
        private void SelectDoctorScreen_Load(object sender, EventArgs e)
        {
            profileImg.Image = profileImage;
            nameLabel.Text = firstName;
            categoryLabel.Text = getCategory();

            string connetionString;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\GitHub\Repositories\Doctor-Appointment-App\Doctor-Appointment-App\MediCareDB.mdf;Integrated Security=True;Connect Timeout=30";

            SqlConnection myConnection = new SqlConnection(connetionString);

            //string oString = "select profileImg,firstName from userTable where username='"+getUsername()+"'";
            string oString = "select * from doctorTable where category='" + getCategory() + "'";
            SqlCommand oCmd = new SqlCommand(oString, myConnection);

            SqlDataAdapter dp = new SqlDataAdapter(oCmd);

            DataSet ds = new DataSet("doctors");

            dp.Fill(ds, "doctors");
            DataRow Row1;
            DataRow Row2;
            DataRow Row3;
            DataRow Row4;
            Row1 = ds.Tables["doctors"].Rows[0];
            Row2 = ds.Tables["doctors"].Rows[1];
            Row3 = ds.Tables["doctors"].Rows[2];
            Row4 = ds.Tables["doctors"].Rows[3];

            // Doctor card 1
            drName1.Text = "Dr. " + (String)Row1["name"];
            drSpecialty1.Text = (String)Row1["category"] + " Specialist";
            drExp1.Text = (String)Row1["experience"] + " Years";
            drPatients1.Text = (String)Row1["patients"] + "K";

            byte[] drImage1 = new byte[0];
            drImage1 = (byte[])Row1["photo"];
            MemoryStream stream1 = new MemoryStream(drImage1);
            drPhoto1.Image = Image.FromStream(stream1);

            // Doctor card 2
            drName2.Text = "Dr. " + (String)Row2["name"];
            drSpecialty2.Text = (String)Row2["category"] + " Specialist";
            drExp2.Text = (String)Row2["experience"] + " Years";
            drPatients2.Text = (String)Row2["patients"] + "K";

            byte[] drImage2 = new byte[0];
            drImage2 = (byte[])Row2["photo"];
            MemoryStream stream2 = new MemoryStream(drImage2);
            drPhoto2.Image = Image.FromStream(stream2);

            // Doctor card 3
            drName3.Text = "Dr. " + (String)Row3["name"];
            drSpecialty3.Text = (String)Row3["category"] + " Specialist";
            drExp3.Text = (String)Row3["experience"] + " Years";
            drPatients3.Text = (String)Row3["patients"] + "K";

            byte[] drImage3 = new byte[0];
            drImage3 = (byte[])Row3["photo"];
            MemoryStream stream3 = new MemoryStream(drImage3);
            drPhoto3.Image = Image.FromStream(stream3);

            // Doctor card 4
            drName4.Text = "Dr. " + (String)Row4["name"];
            drSpecialty4.Text = (String)Row4["category"] + " Specialist";
            drExp4.Text = (String)Row4["experience"] + " Years";
            drPatients4.Text = (String)Row4["patients"] + "K";

            byte[] drImage4 = new byte[0];
            drImage4 = (byte[])Row4["photo"];
            MemoryStream stream4 = new MemoryStream(drImage4);
            drPhoto4.Image = Image.FromStream(stream4);
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

        private void drButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var BookAppointmentScreen = new BookAppointmentScreen();
            BookAppointmentScreen.setUserData(this.username, this.nameLabel.Text, this.profileImg.Image);
            BookAppointmentScreen.setDoctorData(this.drName1.Text, this.drSpecialty1.Text);
            BookAppointmentScreen.setCategory(getCategory());
            BookAppointmentScreen.Closed += (s, args) => this.Close();
            BookAppointmentScreen.Show();
        }

        private void drButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var BookAppointmentScreen = new BookAppointmentScreen();
            BookAppointmentScreen.setUserData(this.username, this.nameLabel.Text, this.profileImg.Image);
            BookAppointmentScreen.setDoctorData(this.drName2.Text, this.drSpecialty2.Text);
            BookAppointmentScreen.setCategory(getCategory());
            BookAppointmentScreen.Closed += (s, args) => this.Close();
            BookAppointmentScreen.Show();
        }

        private void drButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var BookAppointmentScreen = new BookAppointmentScreen();
            BookAppointmentScreen.setUserData(this.username, this.nameLabel.Text, this.profileImg.Image);
            BookAppointmentScreen.setDoctorData(this.drName3.Text, this.drSpecialty3.Text);
            BookAppointmentScreen.setCategory(getCategory());
            BookAppointmentScreen.Closed += (s, args) => this.Close();
            BookAppointmentScreen.Show();
        }

        private void drButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var BookAppointmentScreen = new BookAppointmentScreen();
            BookAppointmentScreen.setUserData(this.username, this.nameLabel.Text, this.profileImg.Image);
            BookAppointmentScreen.setDoctorData(this.drName4.Text, this.drSpecialty4.Text);
            BookAppointmentScreen.setCategory(getCategory());
            BookAppointmentScreen.Closed += (s, args) => this.Close();
            BookAppointmentScreen.Show();
        }

        private void btnChannels_Click(object sender, EventArgs e)
        {
            var AppointmentsScreen = new AppointmentsScreen();
            AppointmentsScreen.setUserData(this.username, this.nameLabel.Text, this.profileImg.Image);
            AppointmentsScreen.Show();
            this.Hide();
            AppointmentsScreen.Closed += (s, args) => this.Close();
        }
    }
}
