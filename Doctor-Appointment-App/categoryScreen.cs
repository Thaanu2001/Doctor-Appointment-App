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

        private void Form1_Load(object sender, EventArgs e)
        {
            string connetionString;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\GitHub\Repositories\Doctor-Appointment-App\Doctor-Appointment-App\MediCareDB.mdf;Integrated Security=True;Connect Timeout=30";

            SqlConnection myConnection = new SqlConnection(connetionString);

            string oString = "select profileImg,firstName from userTable where username='"+getUsername()+"'";
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
    }
}
