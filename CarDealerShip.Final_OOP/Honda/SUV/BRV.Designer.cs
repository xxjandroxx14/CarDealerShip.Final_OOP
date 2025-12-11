namespace CarDealerShip.Final_OOP.Honda.SUV
{
    partial class BRV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BRV));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            buttonBack = new Button();
            buttonfn = new Button();
            buttonCash = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(365, 231);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1, 235);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(349, 213);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 49;
            pictureBox2.TabStop = false;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(713, 384);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 23);
            buttonBack.TabIndex = 50;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonfn
            // 
            buttonfn.Location = new Point(368, 359);
            buttonfn.Name = "buttonfn";
            buttonfn.Size = new Size(75, 23);
            buttonfn.TabIndex = 51;
            buttonfn.Text = "Finnance";
            buttonfn.UseVisualStyleBackColor = true;
            buttonfn.Click += buttonfn_Click;
            // 
            // buttonCash
            // 
            buttonCash.Location = new Point(368, 388);
            buttonCash.Name = "buttonCash";
            buttonCash.Size = new Size(75, 23);
            buttonCash.TabIndex = 52;
            buttonCash.Text = "Cash";
            buttonCash.UseVisualStyleBackColor = true;
            buttonCash.Click += buttonCash_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(392, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(396, 292);
            richTextBox1.TabIndex = 53;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(406, 337);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 54;
            label1.Text = "Payment Method";
            // 
            // BRV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(buttonCash);
            Controls.Add(buttonfn);
            Controls.Add(buttonBack);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "BRV";
            Text = "BRV";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button buttonBack;
        private Button buttonfn;
        private Button buttonCash;
        private RichTextBox richTextBox1;
        private Label label1;
    }
}