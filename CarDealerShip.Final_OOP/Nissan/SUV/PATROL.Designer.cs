namespace CarDealerShip.Final_OOP.Nissan.SUV
{
    partial class PATROL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PATROL));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            buttonBK = new Button();
            buttonFN = new Button();
            buttonCE = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(332, 237);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 84;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-3, 235);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(332, 219);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 85;
            pictureBox2.TabStop = false;
            // 
            // buttonBK
            // 
            buttonBK.Location = new Point(655, 342);
            buttonBK.Name = "buttonBK";
            buttonBK.Size = new Size(75, 23);
            buttonBK.TabIndex = 91;
            buttonBK.Text = "Back";
            buttonBK.UseVisualStyleBackColor = true;
            buttonBK.Click += buttonBK_Click;
            // 
            // buttonFN
            // 
            buttonFN.Location = new Point(439, 342);
            buttonFN.Name = "buttonFN";
            buttonFN.Size = new Size(75, 23);
            buttonFN.TabIndex = 92;
            buttonFN.Text = "Finance";
            buttonFN.UseVisualStyleBackColor = true;
            buttonFN.Click += buttonFN_Click;
            // 
            // buttonCE
            // 
            buttonCE.Location = new Point(439, 387);
            buttonCE.Name = "buttonCE";
            buttonCE.Size = new Size(75, 23);
            buttonCE.TabIndex = 93;
            buttonCE.Text = "Cash";
            buttonCE.UseVisualStyleBackColor = true;
            buttonCE.Click += buttonCE_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(424, 24);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(321, 246);
            richTextBox1.TabIndex = 94;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(424, 296);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 95;
            label1.Text = "Payment Method";
            // 
            // PATROL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(buttonCE);
            Controls.Add(buttonFN);
            Controls.Add(buttonBK);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "PATROL";
            Text = "PATROL";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button buttonBK;
        private Button buttonFN;
        private Button buttonCE;
        private RichTextBox richTextBox1;
        private Label label1;
    }
}