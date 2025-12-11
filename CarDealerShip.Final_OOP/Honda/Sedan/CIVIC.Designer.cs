namespace CarDealerShip.Final_OOP.Honda.Sedan
{
    partial class CIVIC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CIVIC));
            buttonBack = new Button();
            button1 = new Button();
            buttonCash = new Button();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.ImageAlign = ContentAlignment.BottomCenter;
            buttonBack.Location = new Point(713, 374);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 23);
            buttonBack.TabIndex = 35;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // button1
            // 
            button1.ImageAlign = ContentAlignment.BottomCenter;
            button1.Location = new Point(389, 336);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 36;
            button1.Text = "Finance";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonCash
            // 
            buttonCash.ImageAlign = ContentAlignment.BottomCenter;
            buttonCash.Location = new Point(389, 374);
            buttonCash.Name = "buttonCash";
            buttonCash.Size = new Size(75, 23);
            buttonCash.TabIndex = 37;
            buttonCash.Text = "Cash";
            buttonCash.UseVisualStyleBackColor = true;
            buttonCash.Click += buttonCash_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(380, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(408, 255);
            richTextBox1.TabIndex = 38;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, 238);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(364, 215);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-3, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(364, 239);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 40;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(389, 301);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 41;
            label1.Text = "Payment Method";
            // 
            // CIVIC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox1);
            Controls.Add(buttonCash);
            Controls.Add(button1);
            Controls.Add(buttonBack);
            Name = "CIVIC";
            Text = "CIVIC";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBack;
        private Button button1;
        private Button buttonCash;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
    }
}