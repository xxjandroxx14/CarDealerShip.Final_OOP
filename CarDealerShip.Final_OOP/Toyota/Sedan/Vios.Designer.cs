namespace CarDealerShip.Final_OOP
{
    partial class Vios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vios));
            pictureBoxVios = new PictureBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            pictureBoxViosInterior = new PictureBox();
            buttonFinnace = new Button();
            label3 = new Label();
            buttonCash = new Button();
            buttonBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxViosInterior).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxVios
            // 
            pictureBoxVios.Image = (Image)resources.GetObject("pictureBoxVios.Image");
            pictureBoxVios.Location = new Point(12, 12);
            pictureBoxVios.Name = "pictureBoxVios";
            pictureBoxVios.Size = new Size(372, 218);
            pictureBoxVios.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxVios.TabIndex = 0;
            pictureBoxVios.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(390, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(414, 300);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(209, 309);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 3;
            label1.Text = "Price: 900000";
            // 
            // pictureBoxViosInterior
            // 
            pictureBoxViosInterior.Image = (Image)resources.GetObject("pictureBoxViosInterior.Image");
            pictureBoxViosInterior.Location = new Point(12, 236);
            pictureBoxViosInterior.Name = "pictureBoxViosInterior";
            pictureBoxViosInterior.Size = new Size(372, 201);
            pictureBoxViosInterior.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxViosInterior.TabIndex = 5;
            pictureBoxViosInterior.TabStop = false;
            // 
            // buttonFinnace
            // 
            buttonFinnace.ImageAlign = ContentAlignment.BottomCenter;
            buttonFinnace.Location = new Point(524, 382);
            buttonFinnace.Name = "buttonFinnace";
            buttonFinnace.Size = new Size(75, 23);
            buttonFinnace.TabIndex = 8;
            buttonFinnace.Text = "Finance";
            buttonFinnace.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(552, 346);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 11;
            label3.Text = "Payment Method";
            // 
            // buttonCash
            // 
            buttonCash.ImageAlign = ContentAlignment.BottomCenter;
            buttonCash.Location = new Point(619, 382);
            buttonCash.Name = "buttonCash";
            buttonCash.Size = new Size(75, 23);
            buttonCash.TabIndex = 13;
            buttonCash.Text = "Cash";
            buttonCash.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            buttonBack.ImageAlign = ContentAlignment.BottomCenter;
            buttonBack.Location = new Point(424, 382);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 23);
            buttonBack.TabIndex = 54;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // Vios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBack);
            Controls.Add(buttonCash);
            Controls.Add(label3);
            Controls.Add(buttonFinnace);
            Controls.Add(pictureBoxViosInterior);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBoxVios);
            Name = "Vios";
            Text = "Vios";
            Load += Vios_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxVios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxViosInterior).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxVios;
        private Button buttonBuy;
        private RichTextBox richTextBox1;
        private Label label1;
        private Button buttonFinnace;
        private Button buttonCash;
        private PictureBox pictureBoxViosInterior;
        private Label label3;
        private Button buttonBack;
    }
}