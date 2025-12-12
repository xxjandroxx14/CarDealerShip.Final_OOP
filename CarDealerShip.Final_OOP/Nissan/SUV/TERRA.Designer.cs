namespace CarDealerShip.Final_OOP.Nissan.SUV
{
    partial class TERRA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TERRA));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            buttonFinance = new Button();
            buttonCash = new Button();
            buttonBack = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-6, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(336, 248);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 84;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-6, 240);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(336, 209);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 85;
            pictureBox2.TabStop = false;
            // 
            // buttonFinance
            // 
            buttonFinance.Location = new Point(349, 313);
            buttonFinance.Name = "buttonFinance";
            buttonFinance.Size = new Size(75, 23);
            buttonFinance.TabIndex = 86;
            buttonFinance.Text = "Finance";
            buttonFinance.UseVisualStyleBackColor = true;
            buttonFinance.Click += button1_Click;
            // 
            // buttonCash
            // 
            buttonCash.Location = new Point(349, 356);
            buttonCash.Name = "buttonCash";
            buttonCash.Size = new Size(75, 23);
            buttonCash.TabIndex = 87;
            buttonCash.Text = "Cash";
            buttonCash.UseVisualStyleBackColor = true;
            buttonCash.Click += buttonCash_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(713, 356);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 23);
            buttonBack.TabIndex = 88;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(349, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(439, 249);
            richTextBox1.TabIndex = 91;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(349, 278);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 92;
            label1.Text = "Payment Method";
            // 
            // TERRA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(buttonBack);
            Controls.Add(buttonCash);
            Controls.Add(buttonFinance);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "TERRA";
            Text = "TERRA";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button buttonFinance;
        private Button buttonCash;
        private Button buttonBack;
        private RichTextBox richTextBox1;
        private Label label1;
    }
}