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
        private bool throughAppointmentsScreen = false;
        private int appointmentId;

        public BookAppointmentScreen()
        {
            InitializeComponent();
            this.ActiveControl = drName;
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
        public void setThroughAppointmentsScreen(bool through, int id)
        {
            this.throughAppointmentsScreen = through;
            this.appointmentId = id;
        }
        public void setCategory(String cate)
        {
            this.category = cate;
        }
        public String getCategory()
        {
            return category;
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

            if (throughAppointmentsScreen)
            {
                using (SqlConnection myConnection = new SqlConnection(Global.getConnectionString()))
                {
                    string oString = "Select * from appointmentTable where Id=@Id";
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    oCmd.Parameters.AddWithValue("@Id", this.appointmentId);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            this.txtPatientName.Text = oReader["patientName"].ToString();
                            this.txtDate.Value = DateTime.ParseExact(oReader["date"].ToString(), "dd-MM-yyyy", null);
                            this.txtTime.Value = DateTime.ParseExact(oReader["time"].ToString(), "HH:mm", null);
                            this.txtNote.Text = oReader["notes"].ToString();
                        }

                        myConnection.Close();
                    }
                }
            }
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

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (txtPatientName.Text != "") {
                if (!throughAppointmentsScreen) {
                    string sql;

                    SqlConnection cnn = new SqlConnection(Global.getConnectionString());

                    sql = "Insert into appointmentTable (username, doctorName, doctorSpecialty, patientName, date, time, notes) values ('" + this.username + "','" + this.drFullName + "','" + this.drSpecialty + "','" + this.txtPatientName.Text + "','" + this.txtDate.Text.Replace(" ", "") + "','" + this.txtTime.Text.Replace(" ", "") + "','" + this.txtNote.Text + "')";
                    SqlCommand com = new SqlCommand(sql, cnn);

                    cnn.Open();
                    com.ExecuteNonQuery();


                    this.Hide();
                    var categoryScreen = new Form1();
                    categoryScreen.setUsername(username);
                    categoryScreen.Closed += (s, args) => this.Close();
                    categoryScreen.Show();
                    var AppointmentPlacedPopup = new AppointmentPlacedPopup();
                    AppointmentPlacedPopup.Show();
                }
                else
                {
                    string sql;

                    SqlConnection cnn = new SqlConnection(Global.getConnectionString());

                    sql = "Update appointmentTable set patientName='"+ this.txtPatientName.Text +"', date='"+ this.txtDate.Text.Replace(" ","") + "', time='" + this.txtTime.Text.Replace(" ","") + "', notes='" + this.txtNote.Text + "' where Id='"+ this.appointmentId +"'";
                    SqlCommand com = new SqlCommand(sql, cnn);

                    cnn.Open();
                    com.ExecuteNonQuery();


                    this.Hide();
                    var categoryScreen = new Form1();
                    categoryScreen.setUsername(username);
                    categoryScreen.Closed += (s, args) => this.Close();
                    categoryScreen.Show();
                    var AppointmentPlacedPopup = new AppointmentPlacedPopup();
                    AppointmentPlacedPopup.Show();
                }
            }
            else
            {
                errMsg.Visible = true;
            }
        }

        private void btnChannels_Click(object sender, EventArgs e)
        {
            var AppointmentsScreen = new AppointmentsScreen();
            AppointmentsScreen.setUserData(this.username, this.nameLabel.Text, this.profileImg.Image);
            AppointmentsScreen.Show();
            this.Hide();
            AppointmentsScreen.Closed += (s, args) => this.Close();
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
