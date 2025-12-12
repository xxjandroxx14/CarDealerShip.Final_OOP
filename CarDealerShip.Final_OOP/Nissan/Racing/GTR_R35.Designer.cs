namespace CarDealerShip.Final_OOP.Nissan.Racing
{
    partial class GTR_R35
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GTR_R35));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            buttonFn = new Button();
            buttonCh = new Button();
            buttonBk = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-5, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(362, 248);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 84;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-5, 240);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(362, 210);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 85;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // buttonFn
            // 
            buttonFn.Location = new Point(384, 359);
            buttonFn.Name = "buttonFn";
            buttonFn.Size = new Size(75, 23);
            buttonFn.TabIndex = 87;
            buttonFn.Text = "Finance";
            buttonFn.UseVisualStyleBackColor = true;
            buttonFn.Click += buttonFn_Click;
            // 
            // buttonCh
            // 
            buttonCh.Location = new Point(384, 388);
            buttonCh.Name = "buttonCh";
            buttonCh.Size = new Size(75, 23);
            buttonCh.TabIndex = 88;
            buttonCh.Text = "Cash";
            buttonCh.UseVisualStyleBackColor = true;
            buttonCh.Click += buttonCh_Click;
            // 
            // buttonBk
            // 
            buttonBk.Location = new Point(713, 388);
            buttonBk.Name = "buttonBk";
            buttonBk.Size = new Size(75, 23);
            buttonBk.TabIndex = 89;
            buttonBk.Text = "Back";
            buttonBk.UseVisualStyleBackColor = true;
            buttonBk.Click += buttonBk_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(384, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(404, 272);
            richTextBox1.TabIndex = 90;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(384, 331);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 91;
            label1.Text = "Payment Method";
            // 
            // GTR_R35
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(buttonBk);
            Controls.Add(buttonCh);
            Controls.Add(buttonFn);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "GTR_R35";
            Text = "GTR_R35";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button buttonFn;
        private Button buttonCh;
        private Button buttonBk;
        private RichTextBox richTextBox1;
        private Label label1;
    }
}