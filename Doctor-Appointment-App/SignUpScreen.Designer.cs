
namespace Doctor_Appointment_App
{
    partial class SignUpScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpScreen));
            this.errMsg = new System.Windows.Forms.Label();
            this.signinBtn = new System.Windows.Forms.Label();
            this.signupBtn = new System.Windows.Forms.PictureBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.profileImg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.browseImgBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.signupBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseImgBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // errMsg
            // 
            this.errMsg.AutoSize = true;
            this.errMsg.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errMsg.ForeColor = System.Drawing.Color.Red;
            this.errMsg.Location = new System.Drawing.Point(885, 475);
            this.errMsg.Name = "errMsg";
            this.errMsg.Size = new System.Drawing.Size(201, 22);
            this.errMsg.TabIndex = 16;
            this.errMsg.Text = "Incorrect username or password";
            this.errMsg.Visible = false;
            // 
            // signinBtn
            // 
            this.signinBtn.AutoSize = true;
            this.signinBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(232)))), ((int)(((byte)(249)))));
            this.signinBtn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signinBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.signinBtn.Location = new System.Drawing.Point(891, 563);
            this.signinBtn.Name = "signinBtn";
            this.signinBtn.Size = new System.Drawing.Size(279, 28);
            this.signinBtn.TabIndex = 15;
            this.signinBtn.Text = "Already Have an Account? Sign In";
            // 
            // signupBtn
            // 
            this.signupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupBtn.Image = global::Doctor_Appointment_App.Properties.Resources.signup_img;
            this.signupBtn.Location = new System.Drawing.Point(889, 500);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(283, 45);
            this.signupBtn.TabIndex = 14;
            this.signupBtn.TabStop = false;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUser.Location = new System.Drawing.Point(889, 156);
            this.txtUser.Name = "txtUser";
            this.txtUser.PlaceholderText = "Username";
            this.txtUser.Size = new System.Drawing.Size(283, 31);
            this.txtUser.TabIndex = 12;
            this.txtUser.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(232)))), ((int)(((byte)(249)))));
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.label4.Location = new System.Drawing.Point(880, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 48);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sign up";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Doctor_Appointment_App.Properties.Resources.signin_img;
            this.pictureBox1.Location = new System.Drawing.Point(-7, -31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(790, 761);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txtFname
            // 
            this.txtFname.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFname.Location = new System.Drawing.Point(889, 204);
            this.txtFname.Name = "txtFname";
            this.txtFname.PlaceholderText = "First Name";
            this.txtFname.Size = new System.Drawing.Size(283, 31);
            this.txtFname.TabIndex = 17;
            this.txtFname.Tag = "";
            // 
            // txtLname
            // 
            this.txtLname.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLname.Location = new System.Drawing.Point(889, 253);
            this.txtLname.Name = "txtLname";
            this.txtLname.PlaceholderText = "Last Name";
            this.txtLname.Size = new System.Drawing.Size(283, 31);
            this.txtLname.TabIndex = 18;
            this.txtLname.Tag = "";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPass.Location = new System.Drawing.Point(889, 302);
            this.txtPass.Name = "txtPass";
            this.txtPass.PlaceholderText = "Password";
            this.txtPass.Size = new System.Drawing.Size(283, 31);
            this.txtPass.TabIndex = 13;
            this.txtPass.Tag = "";
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(889, 352);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Re-Type Password";
            this.textBox1.Size = new System.Drawing.Size(283, 31);
            this.textBox1.TabIndex = 19;
            this.textBox1.Tag = "";
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // profileImg
            // 
            this.profileImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileImg.Image = global::Doctor_Appointment_App.Properties.Resources.profile_pic;
            this.profileImg.Location = new System.Drawing.Point(889, 402);
            this.profileImg.Name = "profileImg";
            this.profileImg.Size = new System.Drawing.Size(70, 70);
            this.profileImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileImg.TabIndex = 20;
            this.profileImg.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(232)))), ((int)(((byte)(249)))));
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(974, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 28);
            this.label1.TabIndex = 21;
            this.label1.Text = "Profile Picture";
            // 
            // browseImgBtn
            // 
            this.browseImgBtn.Image = global::Doctor_Appointment_App.Properties.Resources.browse_btn;
            this.browseImgBtn.Location = new System.Drawing.Point(979, 431);
            this.browseImgBtn.Name = "browseImgBtn";
            this.browseImgBtn.Size = new System.Drawing.Size(130, 34);
            this.browseImgBtn.TabIndex = 22;
            this.browseImgBtn.TabStop = false;
            this.browseImgBtn.Click += new System.EventHandler(this.browseImgBtn_Click);
            // 
            // SignUpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(232)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1262, 729);
            this.Controls.Add(this.browseImgBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.profileImg);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.errMsg);
            this.Controls.Add(this.signinBtn);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUpScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediCare - Online Doctor Channeling System";
            ((System.ComponentModel.ISupportInitialize)(this.signupBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseImgBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errMsg;
        private System.Windows.Forms.Label signinBtn;
        private System.Windows.Forms.PictureBox signupBtn;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox profileImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox browseImgBtn;
    }
}