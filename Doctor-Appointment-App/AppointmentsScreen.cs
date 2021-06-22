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
    public partial class AppointmentsScreen : Form
    {
        private String username;
        private String firstName;
        private Image profileImage;

        private int id1;
        private int id2;
        private int id3;
        private int id4;

        public AppointmentsScreen()
        {
            InitializeComponent();
        }

        public void setUserData(String usrName, String fName, Image profileImg)
        {
            this.username = usrName;
            this.firstName = fName;
            this.profileImage = profileImg;
        }

        public void ChangeState()
        {
            profileImg.Image = profileImage;
            nameLabel.Text = firstName;

            string connetionString;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\GitHub\Repositories\Doctor-Appointment-App\Doctor-Appointment-App\MediCareDB.mdf;Integrated Security=True;Connect Timeout=30";

            SqlConnection myConnection = new SqlConnection(connetionString);

            //string oString = "select profileImg,firstName from userTable where username='"+getUsername()+"'";
            string oString = "select * from appointmentTable where username='" + "Thaanu" + "'";
            SqlCommand oCmd = new SqlCommand(oString, myConnection);

            SqlDataAdapter dp = new SqlDataAdapter(oCmd);

            DataSet ds = new DataSet("appointments");


            dp.Fill(ds, "appointments");

            int rowCount = ds.Tables["appointments"].Rows.Count;

            DataRow Row1;
            DataRow Row2;
            DataRow Row3;
            DataRow Row4;

            if (rowCount >= 1)
            {
                // Appointment card 1
                appoinmentPanel1.Visible = true;
                Row1 = ds.Tables["appointments"].Rows[0];

                drName1.Text = (String)Row1["doctorName"];
                drSpecialty1.Text = (String)Row1["doctorSpecialty"];
                date1.Text = (String)Row1["date"];
                time1.Text = (String)Row1["time"];
                id1 = (int)Row1["Id"];
            }

            if (rowCount >= 2)
            {
                // Appointment card 1
                appoinmentPanel2.Visible = true;
                Row2 = ds.Tables["appointments"].Rows[1];

                drName2.Text = (String)Row2["doctorName"];
                drSpecialty2.Text = (String)Row2["doctorSpecialty"];
                date2.Text = (String)Row2["date"];
                time2.Text = (String)Row2["time"];
                id2 = (int)Row2["Id"];
            }

            if (rowCount >= 3)
            {
                // Appointment card 3
                backImg1.Visible = false;
                appoinmentPanel3.Visible = true;
                Row3 = ds.Tables["appointments"].Rows[2];

                drName3.Text = (String)Row3["doctorName"];
                drSpecialty3.Text = (String)Row3["doctorSpecialty"];
                date3.Text = (String)Row3["date"];
                time3.Text = (String)Row3["time"];
                id3 = (int)Row3["Id"];
            }

            if (rowCount >= 4)
            {
                // Appointment card 4
                appoinmentPanel4.Visible = true;
                Row4 = ds.Tables["appointments"].Rows[3];

                drName4.Text = (String)Row4["doctorName"];
                drSpecialty4.Text = (String)Row4["doctorSpecialty"];
                date4.Text = (String)Row4["date"];
                time4.Text = (String)Row4["time"];
                id4 = (int)Row4["Id"];
            }
        }

        private void btnCate_MouseEnter(object sender, EventArgs e)
        {
            btnCate.Image = Doctor_Appointment_App.Properties.Resources.sidebar_button_1_hover;
        }
        private void btnCate_MouseLeave(object sender, EventArgs e)
        {
            btnCate.Image = Doctor_Appointment_App.Properties.Resources.sidebar_button_1;
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
        private void btnEdit1_MouseEnter(object sender, EventArgs e)
        {
            btnEdit1.Image = Doctor_Appointment_App.Properties.Resources.appointment_edit_btn_hover;
        }
        private void btnEdit1_MouseLeave(object sender, EventArgs e)
        {
            btnEdit1.Image = Doctor_Appointment_App.Properties.Resources.appointment_edit_btn;
        }
        private void btnEdit2_MouseEnter(object sender, EventArgs e)
        {
            btnEdit2.Image = Doctor_Appointment_App.Properties.Resources.appointment_edit_btn_hover;
        }
        private void btnEdit2_MouseLeave(object sender, EventArgs e)
        {
            btnEdit2.Image = Doctor_Appointment_App.Properties.Resources.appointment_edit_btn;
        }
        private void btnEdit3_MouseEnter(object sender, EventArgs e)
        {
            btnEdit3.Image = Doctor_Appointment_App.Properties.Resources.appointment_edit_btn_hover;
        }
        private void btnEdit3_MouseLeave(object sender, EventArgs e)
        {
            btnEdit3.Image = Doctor_Appointment_App.Properties.Resources.appointment_edit_btn;
        }
        private void btnEdit4_MouseEnter(object sender, EventArgs e)
        {
            btnEdit4.Image = Doctor_Appointment_App.Properties.Resources.appointment_edit_btn_hover;
        }
        private void btnEdit4_MouseLeave(object sender, EventArgs e)
        {
            btnEdit4.Image = Doctor_Appointment_App.Properties.Resources.appointment_edit_btn;
        }
        private void btnCancel1_MouseEnter(object sender, EventArgs e)
        {
            btnCancel1.Image = Doctor_Appointment_App.Properties.Resources.appointment_cancel_btn_hover;
        }
        private void btnCancel1_MouseLeave(object sender, EventArgs e)
        {
            btnCancel1.Image = Doctor_Appointment_App.Properties.Resources.appointment_cancel_btn;
        }
        private void btnCancel2_MouseEnter(object sender, EventArgs e)
        {
            btnCancel2.Image = Doctor_Appointment_App.Properties.Resources.appointment_cancel_btn_hover;
        }
        private void btnCancel2_MouseLeave(object sender, EventArgs e)
        {
            btnCancel2.Image = Doctor_Appointment_App.Properties.Resources.appointment_cancel_btn;
        }
        private void btnCancel3_MouseEnter(object sender, EventArgs e)
        {
            btnCancel3.Image = Doctor_Appointment_App.Properties.Resources.appointment_cancel_btn_hover;
        }
        private void btnCancel3_MouseLeave(object sender, EventArgs e)
        {
            btnCancel3.Image = Doctor_Appointment_App.Properties.Resources.appointment_cancel_btn;
        }
        private void btnCancel4_MouseEnter(object sender, EventArgs e)
        {
            btnCancel4.Image = Doctor_Appointment_App.Properties.Resources.appointment_cancel_btn_hover;
        }
        private void btnCancel4_MouseLeave(object sender, EventArgs e)
        {
            btnCancel4.Image = Doctor_Appointment_App.Properties.Resources.appointment_cancel_btn;
        }

        private void AppointmentsScreen_Load(object sender, EventArgs e)
        {
            profileImg.Image = profileImage;
            nameLabel.Text = firstName;

            string connetionString;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\GitHub\Repositories\Doctor-Appointment-App\Doctor-Appointment-App\MediCareDB.mdf;Integrated Security=True;Connect Timeout=30";

            SqlConnection myConnection = new SqlConnection(connetionString);

            //string oString = "select profileImg,firstName from userTable where username='"+getUsername()+"'";
            string oString = "select * from appointmentTable where username='" + username + "'";
            SqlCommand oCmd = new SqlCommand(oString, myConnection);

            SqlDataAdapter dp = new SqlDataAdapter(oCmd);

            DataSet ds = new DataSet("appointments");


            dp.Fill(ds, "appointments");

            int rowCount = ds.Tables["appointments"].Rows.Count;

            DataRow Row1;
            DataRow Row2;
            DataRow Row3;
            DataRow Row4;

            if (rowCount >= 1) {
                // Appointment card 1
                appoinmentPanel1.Visible = true;
                Row1 = ds.Tables["appointments"].Rows[0];

                drName1.Text = (String)Row1["doctorName"];
                drSpecialty1.Text = (String)Row1["doctorSpecialty"];
                date1.Text = (String)Row1["date"];
                time1.Text = (String)Row1["time"];
                id1 = (int)Row1["Id"];
            }

            if (rowCount >= 2)
            {
                // Appointment card 1
                appoinmentPanel2.Visible = true;
                Row2 = ds.Tables["appointments"].Rows[1];

                drName2.Text = (String)Row2["doctorName"];
                drSpecialty2.Text = (String)Row2["doctorSpecialty"];
                date2.Text = (String)Row2["date"];
                time2.Text = (String)Row2["time"];
                id2 = (int)Row2["Id"];
            }

            if (rowCount >= 3)
            {
                // Appointment card 3
                backImg1.Visible = false;
                appoinmentPanel3.Visible = true;
                Row3 = ds.Tables["appointments"].Rows[2];

                drName3.Text = (String)Row3["doctorName"];
                drSpecialty3.Text = (String)Row3["doctorSpecialty"];
                date3.Text = (String)Row3["date"];
                time3.Text = (String)Row3["time"];
                id3 = (int)Row3["Id"];
            }

            if (rowCount >= 4)
            {
                // Appointment card 4
                appoinmentPanel4.Visible = true;
                Row4 = ds.Tables["appointments"].Rows[3];

                drName4.Text = (String)Row4["doctorName"];
                drSpecialty4.Text = (String)Row4["doctorSpecialty"];
                date4.Text = (String)Row4["date"];
                time4.Text = (String)Row4["time"];
                id4 = (int)Row4["Id"];
            }
        }

        private void btnCate_Click(object sender, EventArgs e)
        {
            this.Hide();
            var categoryScreen = new Form1();
            categoryScreen.setUsername(username);
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

        private void btnEdit1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var BookAppointmentScreen = new BookAppointmentScreen();
            BookAppointmentScreen.setUserData(this.username, this.nameLabel.Text, this.profileImg.Image);
            BookAppointmentScreen.setDoctorData(this.drName1.Text, this.drSpecialty1.Text);
            BookAppointmentScreen.setCategory(this.drSpecialty1.Text.Replace(" Specialist",""));
            BookAppointmentScreen.setThroughAppointmentsScreen(true, id1);
            BookAppointmentScreen.Closed += (s, args) => this.Close();
            BookAppointmentScreen.Show();
        }

        private void btnEdit2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var BookAppointmentScreen = new BookAppointmentScreen();
            BookAppointmentScreen.setUserData(this.username, this.nameLabel.Text, this.profileImg.Image);
            BookAppointmentScreen.setDoctorData(this.drName2.Text, this.drSpecialty2.Text);
            BookAppointmentScreen.setCategory(this.drSpecialty2.Text.Replace(" Specialist", ""));
            BookAppointmentScreen.setThroughAppointmentsScreen(true, id2);
            BookAppointmentScreen.Closed += (s, args) => this.Close();
            BookAppointmentScreen.Show();
        }

        private void btnEdit3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var BookAppointmentScreen = new BookAppointmentScreen();
            BookAppointmentScreen.setUserData(this.username, this.nameLabel.Text, this.profileImg.Image);
            BookAppointmentScreen.setDoctorData(this.drName3.Text, this.drSpecialty3.Text);
            BookAppointmentScreen.setCategory(this.drSpecialty3.Text.Replace(" Specialist", ""));
            BookAppointmentScreen.setThroughAppointmentsScreen(true, id3);
            BookAppointmentScreen.Closed += (s, args) => this.Close();
            BookAppointmentScreen.Show();
        }

        private void btnEdit4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var BookAppointmentScreen = new BookAppointmentScreen();
            BookAppointmentScreen.setUserData(this.username, this.nameLabel.Text, this.profileImg.Image);
            BookAppointmentScreen.setDoctorData(this.drName4.Text, this.drSpecialty4.Text);
            BookAppointmentScreen.setCategory(this.drSpecialty4.Text.Replace(" Specialist", ""));
            BookAppointmentScreen.setThroughAppointmentsScreen(true, id4);
            BookAppointmentScreen.Closed += (s, args) => this.Close();
            BookAppointmentScreen.Show();
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            var CancelAppointmentPopup = new CancelAppointmentPopup();
            CancelAppointmentPopup.setUserData(this.username, this.nameLabel.Text, this.profileImg.Image);
            CancelAppointmentPopup.setAppointmentsId(id1);
            CancelAppointmentPopup.Show();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            var CancelAppointmentPopup = new CancelAppointmentPopup();
            CancelAppointmentPopup.setUserData(this.username, this.nameLabel.Text, this.profileImg.Image);
            CancelAppointmentPopup.setAppointmentsId(id2);
            CancelAppointmentPopup.Show();
        }

        private void btnCancel3_Click(object sender, EventArgs e)
        {
            var CancelAppointmentPopup = new CancelAppointmentPopup();
            CancelAppointmentPopup.setUserData(this.username, this.nameLabel.Text, this.profileImg.Image);
            CancelAppointmentPopup.setAppointmentsId(id3);
            CancelAppointmentPopup.Show();
        }

        private void btnCancel4_Click(object sender, EventArgs e)
        {
            var CancelAppointmentPopup = new CancelAppointmentPopup();
            CancelAppointmentPopup.setUserData(this.username, this.nameLabel.Text, this.profileImg.Image);
            CancelAppointmentPopup.setAppointmentsId(id4);
            CancelAppointmentPopup.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            var AboutScreen = new AboutScreen();
            AboutScreen.setUserData(this.username, this.nameLabel.Text, this.profileImg.Image);
            AboutScreen.Show();
            this.Hide();
            AboutScreen.Closed += (s, args) => this.Close();
        }
    }
}
