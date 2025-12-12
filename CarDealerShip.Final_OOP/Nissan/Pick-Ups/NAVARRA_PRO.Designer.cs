namespace CarDealerShip.Final_OOP.Nissan.Pick_Ups
{
    partial class NAVARRA_PRO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NAVARRA_PRO));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            buttonFE = new Button();
            buttonCE = new Button();
            buttonBK = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 237);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(309, 210);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 84;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-1, -5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(309, 245);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 85;
            pictureBox2.TabStop = false;
            // 
            // buttonFE
            // 
            buttonFE.Location = new Point(333, 332);
            buttonFE.Name = "buttonFE";
            buttonFE.Size = new Size(75, 23);
            buttonFE.TabIndex = 87;
            buttonFE.Text = "Finance";
            buttonFE.UseVisualStyleBackColor = true;
            buttonFE.Click += button1_Click;
            // 
            // buttonCE
            // 
            buttonCE.Location = new Point(333, 383);
            buttonCE.Name = "buttonCE";
            buttonCE.Size = new Size(75, 23);
            buttonCE.TabIndex = 88;
            buttonCE.Text = "Cash";
            buttonCE.UseVisualStyleBackColor = true;
            buttonCE.Click += buttonCE_Click;
            // 
            // buttonBK
            // 
            buttonBK.Location = new Point(713, 383);
            buttonBK.Name = "buttonBK";
            buttonBK.Size = new Size(75, 23);
            buttonBK.TabIndex = 89;
            buttonBK.Text = "Back";
            buttonBK.UseVisualStyleBackColor = true;
            buttonBK.Click += buttonBK_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(333, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(455, 258);
            richTextBox1.TabIndex = 91;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(333, 299);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 92;
            label1.Text = "Payment Method";
            // 
            // NAVARRA_PRO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(buttonBK);
            Controls.Add(buttonCE);
            Controls.Add(buttonFE);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "NAVARRA_PRO";
            Text = "NAVARRA_PRO";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button buttonFE;
        private Button buttonCE;
        private Button buttonBK;
        private RichTextBox richTextBox1;
        private Label label1;
    }
}