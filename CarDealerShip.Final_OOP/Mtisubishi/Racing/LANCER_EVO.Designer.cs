namespace CarDealerShip.Final_OOP.Mtisubishi.Racing
{
    partial class LANCER_EVO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LANCER_EVO));
            buttonBK = new Button();
            buttonCE = new Button();
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
            // buttonBK
            // 
            buttonBK.ImageAlign = ContentAlignment.BottomCenter;
            buttonBK.Location = new Point(709, 396);
            buttonBK.Name = "buttonBK";
            buttonBK.Size = new Size(75, 23);
            buttonBK.TabIndex = 131;
            buttonBK.Text = "Back";
            buttonBK.UseVisualStyleBackColor = true;
            buttonBK.Click += buttonBK_Click;
            // 
            // buttonCE
            // 
            buttonCE.ImageAlign = ContentAlignment.BottomCenter;
            buttonCE.Location = new Point(378, 396);
            buttonCE.Name = "buttonCE";
            buttonCE.Size = new Size(75, 23);
            buttonCE.TabIndex = 130;
            buttonCE.Text = "Cash";
            buttonCE.UseVisualStyleBackColor = true;
            buttonCE.Click += buttonCE_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(378, 340);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 129;
            label3.Text = "Payment Method";
            // 
            // buttonFinnace
            // 
            buttonFinnace.ImageAlign = ContentAlignment.BottomCenter;
            buttonFinnace.Location = new Point(378, 367);
            buttonFinnace.Name = "buttonFinnace";
            buttonFinnace.Size = new Size(75, 23);
            buttonFinnace.TabIndex = 128;
            buttonFinnace.Text = "Finance";
            buttonFinnace.UseVisualStyleBackColor = true;
            buttonFinnace.Click += buttonFinnace_Click;
            // 
            // pictureBoxViosInterior
            // 
            pictureBoxViosInterior.Image = (Image)resources.GetObject("pictureBoxViosInterior.Image");
            pictureBoxViosInterior.Location = new Point(-7, 241);
            pictureBoxViosInterior.Name = "pictureBoxViosInterior";
            pictureBoxViosInterior.Size = new Size(331, 211);
            pictureBoxViosInterior.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxViosInterior.TabIndex = 127;
            pictureBoxViosInterior.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 310);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 126;
            label1.Text = "Price: 900000";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(378, 13);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(414, 300);
            richTextBox1.TabIndex = 125;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // pictureBoxVios
            // 
            pictureBoxVios.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxVios.Image = (Image)resources.GetObject("pictureBoxVios.Image");
            pictureBoxVios.Location = new Point(-7, -2);
            pictureBoxVios.Name = "pictureBoxVios";
            pictureBoxVios.Size = new Size(331, 247);
            pictureBoxVios.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxVios.TabIndex = 124;
            pictureBoxVios.TabStop = false;
            // 
            // LANCER_EVO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBK);
            Controls.Add(buttonCE);
            Controls.Add(label3);
            Controls.Add(buttonFinnace);
            Controls.Add(pictureBoxViosInterior);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBoxVios);
            Name = "LANCER_EVO";
            Text = "LANCER_EVO";
            Load += LANCER_EVO_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxViosInterior).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBK;
        private Button buttonCE;
        private Label label3;
        private Button buttonFinnace;
        private PictureBox pictureBoxViosInterior;
        private Label label1;
        private RichTextBox richTextBox1;
        private PictureBox pictureBoxVios;
    }
}