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
    public partial class CancelAppointmentPopup : Form
    {
        private int appointmentId;
        private String username;
        private String firstName;
        private Image profileImage;

        public CancelAppointmentPopup()
        {
            InitializeComponent();
        }
        public void setUserData(String usrName, String fName, Image profileImg)
        {
            this.username = usrName;
            this.firstName = fName;
            this.profileImage = profileImg;
        }

        public void setAppointmentsId(int id)
        {
            this.appointmentId = id;
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.Image = Doctor_Appointment_App.Properties.Resources.appointment_cancel_btn_hover;
        }
        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.Image = Doctor_Appointment_App.Properties.Resources.appointment_cancel_btn;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string connetionString;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\GitHub\Repositories\Doctor-Appointment-App\Doctor-Appointment-App\MediCareDB.mdf;Integrated Security=True;Connect Timeout=30";

            SqlConnection con = new SqlConnection(connetionString);
            con.Open();

            string sql = "Delete appointmentTable WHERE Id = '" + appointmentId + "'";
            SqlCommand com = new SqlCommand(sql, con);
            com.ExecuteNonQuery();

            for (int i = Application.OpenForms.Count - 1; i > 0; i--)
            {
                    Application.OpenForms[i].Hide();
            }

            var AppointmentsScreen = new AppointmentsScreen();
            AppointmentsScreen.setUserData(this.username, this.firstName, this.profileImage);
            AppointmentsScreen.Show();
            this.Hide();
            AppointmentsScreen.Closed += (s, args) => this.Close();
        }
    }
}
