namespace CarDealerShip.Final_OOP.Mtisubishi.Sedan
{
    partial class MIRAGE_G4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MIRAGE_G4));
            buttonBack = new Button();
            button1 = new Button();
            label3 = new Label();
            buttonFinnace = new Button();
            pictureBoxViosInterior = new PictureBox();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            pictureBoxVios = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxViosInterior).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVios).BeginInit();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.ImageAlign = ContentAlignment.BottomCenter;
            buttonBack.Location = new Point(709, 396);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 23);
            buttonBack.TabIndex = 139;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click_1;
            // 
            // button1
            // 
            button1.ImageAlign = ContentAlignment.BottomCenter;
            button1.Location = new Point(378, 396);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 138;
            button1.Text = "Cash";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(378, 340);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 137;
            label3.Text = "Payment Method";
            // 
            // buttonFinnace
            // 
            buttonFinnace.ImageAlign = ContentAlignment.BottomCenter;
            buttonFinnace.Location = new Point(378, 367);
            buttonFinnace.Name = "buttonFinnace";
            buttonFinnace.Size = new Size(75, 23);
            buttonFinnace.TabIndex = 136;
            buttonFinnace.Text = "Finance";
            buttonFinnace.UseVisualStyleBackColor = true;
            buttonFinnace.Click += buttonFinnace_Click;
            // 
            // pictureBoxViosInterior
            // 
            pictureBoxViosInterior.Image = (Image)resources.GetObject("pictureBoxViosInterior.Image");
            pictureBoxViosInterior.Location = new Point(-1, 232);
            pictureBoxViosInterior.Name = "pictureBoxViosInterior";
            pictureBoxViosInterior.Size = new Size(340, 217);
            pictureBoxViosInterior.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxViosInterior.TabIndex = 135;
            pictureBoxViosInterior.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 310);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 134;
            label1.Text = "Price: 900000";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(378, 13);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(414, 300);
            richTextBox1.TabIndex = 133;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // pictureBoxVios
            // 
            pictureBoxVios.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxVios.Image = (Image)resources.GetObject("pictureBoxVios.Image");
            pictureBoxVios.Location = new Point(-1, 1);
            pictureBoxVios.Name = "pictureBoxVios";
            pictureBoxVios.Size = new Size(340, 234);
            pictureBoxVios.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxVios.TabIndex = 132;
            pictureBoxVios.TabStop = false;
            // 
            // MIRAGE_G4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBack);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(buttonFinnace);
            Controls.Add(pictureBoxViosInterior);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBoxVios);
            Name = "MIRAGE_G4";
            Text = "MIRAGE_G4";
            ((System.ComponentModel.ISupportInitialize)pictureBoxViosInterior).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBack;
        private Button button1;
        private Label label3;
        private Button buttonFinnace;
        private PictureBox pictureBoxViosInterior;
        private Label label1;
        private RichTextBox richTextBox1;
        private PictureBox pictureBoxVios;
    }
}