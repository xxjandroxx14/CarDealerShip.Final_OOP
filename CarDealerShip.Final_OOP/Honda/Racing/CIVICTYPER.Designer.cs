namespace CarDealerShip.Final_OOP.Honda.Racing
{
    partial class CIVICTYPER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CIVICTYPER));
            buttonfe = new Button();
            buttonch = new Button();
            buttonBk = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // buttonfe
            // 
            buttonfe.Location = new Point(404, 364);
            buttonfe.Name = "buttonfe";
            buttonfe.Size = new Size(75, 23);
            buttonfe.TabIndex = 43;
            buttonfe.Text = "Fianance";
            buttonfe.UseVisualStyleBackColor = true;
            buttonfe.Click += buttonfe_Click;
            // 
            // buttonch
            // 
            buttonch.Location = new Point(404, 393);
            buttonch.Name = "buttonch";
            buttonch.Size = new Size(75, 23);
            buttonch.TabIndex = 44;
            buttonch.Text = "Cash";
            buttonch.UseVisualStyleBackColor = true;
            buttonch.Click += buttonch_Click;
            // 
            // buttonBk
            // 
            buttonBk.Location = new Point(697, 364);
            buttonBk.Name = "buttonBk";
            buttonBk.Size = new Size(75, 23);
            buttonBk.TabIndex = 45;
            buttonBk.Text = "Back";
            buttonBk.UseVisualStyleBackColor = true;
            buttonBk.Click += buttonBk_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-7, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(331, 222);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 85;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-7, 220);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(331, 235);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 86;
            pictureBox2.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(381, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(391, 299);
            richTextBox1.TabIndex = 87;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(404, 328);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 88;
            label1.Text = "Payment Method";
            // 
            // CIVICTYPER
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(buttonBk);
            Controls.Add(buttonch);
            Controls.Add(buttonfe);
            Name = "CIVICTYPER";
            Text = "CIVICTYPER";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonfe;
        private Button buttonch;
        private Button buttonBk;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private RichTextBox richTextBox1;
        private Label label1;
    }
}