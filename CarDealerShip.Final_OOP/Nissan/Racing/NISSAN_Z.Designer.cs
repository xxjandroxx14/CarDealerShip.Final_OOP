namespace CarDealerShip.Final_OOP.Nissan.Racing
{
    partial class NISSAN_Z
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NISSAN_Z));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            buttonFN = new Button();
            buttonCH = new Button();
            buttonBK = new Button();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(331, 206);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 84;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1, 223);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(351, 203);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 85;
            pictureBox2.TabStop = false;
            // 
            // buttonFN
            // 
            buttonFN.Location = new Point(398, 326);
            buttonFN.Name = "buttonFN";
            buttonFN.Size = new Size(75, 23);
            buttonFN.TabIndex = 87;
            buttonFN.Text = "Finance";
            buttonFN.UseVisualStyleBackColor = true;
            buttonFN.Click += buttonFN_Click;
            // 
            // buttonCH
            // 
            buttonCH.Location = new Point(410, 376);
            buttonCH.Name = "buttonCH";
            buttonCH.Size = new Size(75, 23);
            buttonCH.TabIndex = 88;
            buttonCH.Text = "Cash";
            buttonCH.UseVisualStyleBackColor = true;
            buttonCH.Click += buttonCH_Click;
            // 
            // buttonBK
            // 
            buttonBK.Location = new Point(660, 366);
            buttonBK.Name = "buttonBK";
            buttonBK.Size = new Size(97, 21);
            buttonBK.TabIndex = 89;
            buttonBK.Text = "Back";
            buttonBK.UseVisualStyleBackColor = true;
            buttonBK.Click += buttonBK_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(436, 37);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(271, 195);
            richTextBox1.TabIndex = 91;
            richTextBox1.Text = "";
            // 
            // NISSAN_Z
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(buttonBK);
            Controls.Add(buttonCH);
            Controls.Add(buttonFN);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "NISSAN_Z";
            Text = "NISSAN_Z";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button buttonFN;
        private Button buttonCH;
        private Button buttonBK;
        private RichTextBox richTextBox1;
    }
}