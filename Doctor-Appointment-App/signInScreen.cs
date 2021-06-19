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
    public partial class signInScreen : Form
    {
        public signInScreen()
        {
            InitializeComponent();
        }

        private void signinBtn_Click(object sender, EventArgs e)
        {
            string connetionString;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\GitHub\Repositories\Doctor-Appointment-App\Doctor-Appointment-App\MediCareDB.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection myConnection = new SqlConnection(connetionString))
            {
                string oString = "Select * from userTable where username=@username";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                oCmd.Parameters.AddWithValue("@username", this.txtUser.Text);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        if (txtPass.Text == oReader["password"].ToString())
                        {
                            var categoryScreen = new Form1();
                            categoryScreen.setUsername(this.txtUser.Text);
                            categoryScreen.Show();
                            this.Hide();
                            categoryScreen.Closed += (s, args) => this.Close();
                        }
                        else {
                            errMsg.Visible = true;
                        };
                    }
                    if (!oReader.HasRows)
                    {
                        errMsg.Visible = true;
                    }

                    myConnection.Close();
                }
            }
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            var SignUpScreen = new SignUpScreen();
            SignUpScreen.Show();
            this.Hide();
            SignUpScreen.Closed += (s, args) => this.Close();
        }
    }
}
