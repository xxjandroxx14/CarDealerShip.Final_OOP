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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(264, 222);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 84;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 240);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(310, 182);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 85;
            pictureBox2.TabStop = false;
            // 
            // buttonFinance
            // 
            buttonFinance.Location = new Point(391, 336);
            buttonFinance.Name = "buttonFinance";
            buttonFinance.Size = new Size(75, 23);
            buttonFinance.TabIndex = 86;
            buttonFinance.Text = "Finance";
            buttonFinance.UseVisualStyleBackColor = true;
            buttonFinance.Click += button1_Click;
            // 
            // buttonCash
            // 
            buttonCash.Location = new Point(391, 383);
            buttonCash.Name = "buttonCash";
            buttonCash.Size = new Size(75, 23);
            buttonCash.TabIndex = 87;
            buttonCash.Text = "Cash";
            buttonCash.UseVisualStyleBackColor = true;
            buttonCash.Click += buttonCash_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(680, 365);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 23);
            buttonBack.TabIndex = 88;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(391, 26);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(364, 247);
            richTextBox1.TabIndex = 91;
            richTextBox1.Text = "";
            // 
            // TERRA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button buttonFinance;
        private Button buttonCash;
        private Button buttonBack;
        private RichTextBox richTextBox1;
    }
}