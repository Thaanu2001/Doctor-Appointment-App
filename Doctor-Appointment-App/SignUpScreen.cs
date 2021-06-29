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
    public partial class SignUpScreen : Form
    {
        public SignUpScreen()
        {
            InitializeComponent();
        }

        private void browseImgBtn_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                //profileImg.Image = new Bitmap(open.FileName);
                profileImg.Image = Image.FromFile(open.FileName);
                // image file path  
                //textBox1.Text = open.FileName;
            }

        }

        private void signinBtn_Click(object sender, EventArgs e)
        {
            // Open Sign in screen
            var signInScreen = new signInScreen();
            signInScreen.Show();
            this.Hide();
            signInScreen.Closed += (s, args) => this.Close();
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            // Register user
            if (txtPass.Text == txtPass2.Text && txtUser.Text != "" && txtPass.Text != "") {
                string sql;
                int queryStatus = 0;

                SqlConnection cnn = new SqlConnection(Global.getConnectionString());

                sql = "Insert into userTable (username, password, firstName, lastName, profileImg) values ('" + this.txtUser.Text + "','" + this.txtPass.Text + "','" + this.txtFname.Text + "','" + this.txtLname.Text + "',@profilePic)";
                SqlCommand com = new SqlCommand(sql, cnn);

                MemoryStream stream = new MemoryStream();
                profileImg.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);

                byte[] profilePic = stream.ToArray();
                com.Parameters.AddWithValue("@profilePic", profilePic);

                try
                {
                    cnn.Open();
                    queryStatus = com.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        errMsg.Text = "Username already exists";
                        errMsg.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show(ex.Number.ToString());
                    }
                }
                finally
                {
                    cnn.Close();

                    if (queryStatus != 0) {
                        var categoryScreen = new Form1();
                        categoryScreen.setUsername(this.txtUser.Text);
                        categoryScreen.Show();
                        this.Hide();
                        categoryScreen.Closed += (s, args) => this.Close(); 
                    }
                }
            }
            else if(txtUser.Text == "" || txtPass.Text == "")
            {
                errMsg.Text = "Enter all the details correctly";
                errMsg.Visible = true;
            }
            else {
                errMsg.Text = "Passwords doesn't match";
                errMsg.Visible = true;
            }
        }

        private void txtPass2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
