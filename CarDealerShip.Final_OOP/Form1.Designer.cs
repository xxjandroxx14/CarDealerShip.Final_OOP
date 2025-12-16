namespace CarDealerShip.Final_OOP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ButtonSignup = new Button();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            buttonAdminList = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ButtonSignup
            // 
            ButtonSignup.Location = new Point(36, 214);
            ButtonSignup.Name = "ButtonSignup";
            ButtonSignup.Size = new Size(75, 23);
            ButtonSignup.TabIndex = 0;
            ButtonSignup.Text = "Signup";
            ButtonSignup.UseVisualStyleBackColor = true;
            ButtonSignup.Click += ButtonSignup_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(47, 121);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(174, 23);
            textBoxEmail.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(47, 164);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(174, 23);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.Tag = "*";
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(146, 214);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(75, 23);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click_1;
            // 
            // buttonAdminList
            // 
            buttonAdminList.BackColor = SystemColors.Control;
            buttonAdminList.Location = new Point(1, 0);
            buttonAdminList.Name = "buttonAdminList";
            buttonAdminList.Size = new Size(10, 10);
            buttonAdminList.TabIndex = 6;
            buttonAdminList.UseVisualStyleBackColor = false;
            buttonAdminList.Click += buttonAdminList_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(88, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(292, 264);
            Controls.Add(buttonAdminList);
            Controls.Add(pictureBox1);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(ButtonSignup);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonSignup;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private Button buttonLogin;
        private Button buttonAdminList;
        private PictureBox pictureBox1;
    }
}
