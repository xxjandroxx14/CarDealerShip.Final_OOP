namespace CarDealerShip.Final_OOP.Nissan.Sedan
{
    partial class ALMERA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ALMERA));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            buttonFianance = new Button();
            button2 = new Button();
            buttonback = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(315, 249);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 84;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-1, 249);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(315, 206);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 85;
            pictureBox2.TabStop = false;
            // 
            // buttonFianance
            // 
            buttonFianance.Location = new Point(384, 352);
            buttonFianance.Name = "buttonFianance";
            buttonFianance.Size = new Size(75, 23);
            buttonFianance.TabIndex = 87;
            buttonFianance.Text = "Fianance";
            buttonFianance.UseVisualStyleBackColor = true;
            buttonFianance.Click += buttonFianance_Click;
            // 
            // button2
            // 
            button2.Location = new Point(384, 381);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 88;
            button2.Text = "Cash";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonback
            // 
            buttonback.Location = new Point(575, 364);
            buttonback.Name = "buttonback";
            buttonback.Size = new Size(75, 23);
            buttonback.TabIndex = 89;
            buttonback.Text = "Back";
            buttonback.UseVisualStyleBackColor = true;
            buttonback.Click += buttonback_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(370, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(381, 282);
            richTextBox1.TabIndex = 91;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(384, 309);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 92;
            label1.Text = "Payment Method";
            // 
            // ALMERA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(buttonback);
            Controls.Add(button2);
            Controls.Add(buttonFianance);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "ALMERA";
            Text = "ALMERA";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button buttonFianance;
        private Button button2;
        private Button buttonback;
        private RichTextBox richTextBox1;
        private Label label1;
    }
}