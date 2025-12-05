namespace CarDealerShip.Final_OOP
{
    partial class ListForm
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
            datagridviewClient = new DataGridView();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            Password = new Label();
            ((System.ComponentModel.ISupportInitialize)datagridviewClient).BeginInit();
            SuspendLayout();
            // 
            // datagridviewClient
            // 
            datagridviewClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridviewClient.Location = new Point(225, 71);
            datagridviewClient.Name = "datagridviewClient";
            datagridviewClient.Size = new Size(329, 187);
            datagridviewClient.TabIndex = 1;
            datagridviewClient.CellContentClick += datagridviewClient_CellContentClick;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(225, 264);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Delete ";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(479, 264);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 23);
            buttonUpdate.TabIndex = 3;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(102, 111);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 4;
            txtEmail.TextChanged += textBoxEmailList_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(102, 155);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 111);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 6;
            label1.Text = "Email";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(39, 155);
            Password.Name = "Password";
            Password.Size = new Size(57, 15);
            Password.TabIndex = 7;
            Password.Text = "Password";
            // 
            // ListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Password);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonDelete);
            Controls.Add(datagridviewClient);
            Name = "ListForm";
            Text = "ListForm";
            ((System.ComponentModel.ISupportInitialize)datagridviewClient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView datagridviewClient;
        private Button buttonDelete;
        private Button buttonUpdate;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label label1;
        private Label Password;
    }
}