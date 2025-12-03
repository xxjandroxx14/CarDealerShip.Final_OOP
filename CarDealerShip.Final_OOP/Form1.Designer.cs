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
            ButtonSignup = new Button();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonLogin = new Button();
            buttonAdminList = new Button();
            SuspendLayout();
            // 
            // ButtonSignup
            // 
            ButtonSignup.Location = new Point(26, 192);
            ButtonSignup.Name = "ButtonSignup";
            ButtonSignup.Size = new Size(75, 23);
            ButtonSignup.TabIndex = 0;
            ButtonSignup.Text = "Signup";
            ButtonSignup.UseVisualStyleBackColor = true;
            ButtonSignup.Click += ButtonSignup_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(121, 61);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(100, 23);
            textBoxEmail.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(121, 105);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(100, 23);
            textBoxPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 61);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 3;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 108);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(172, 192);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(75, 23);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += button1_Click;
            // 
            // buttonAdminList
            // 
            buttonAdminList.BackColor = SystemColors.Control;
            buttonAdminList.Location = new Point(1, 0);
            buttonAdminList.Name = "buttonAdminList";
            buttonAdminList.Size = new Size(10, 23);
            buttonAdminList.TabIndex = 6;
            buttonAdminList.UseVisualStyleBackColor = false;
            buttonAdminList.Click += buttonAdminList_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 264);
            Controls.Add(buttonAdminList);
            Controls.Add(buttonLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(ButtonSignup);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonSignup;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private Label label1;
        private Label label2;
        private Button buttonLogin;
        private Button buttonAdminList;
    }
}
