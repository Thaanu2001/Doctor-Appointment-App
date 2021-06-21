using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Doctor_Appointment_App
{
    public partial class AppointmentPlacedPopup : Form
    {
        public AppointmentPlacedPopup()
        {
            InitializeComponent();
        }
        private void btnOk_MouseEnter(object sender, EventArgs e)
        {
            btnOk.Image = Doctor_Appointment_App.Properties.Resources.ok_btn_hover;
        }
        private void btnOk_MouseLeave(object sender, EventArgs e)
        {
            btnOk.Image = Doctor_Appointment_App.Properties.Resources.ok_btn;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
