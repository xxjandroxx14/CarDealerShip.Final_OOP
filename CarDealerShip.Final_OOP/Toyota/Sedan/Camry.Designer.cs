namespace CarDealerShip.Final_OOP
{
    partial class Camry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Camry));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            richTextBox1 = new RichTextBox();
            buttonCash = new Button();
            buttonBack = new Button();
            buttonFinnance = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(368, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 222);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(368, 216);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(418, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(370, 309);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // buttonCash
            // 
            buttonCash.ImageAlign = ContentAlignment.BottomCenter;
            buttonCash.Location = new Point(409, 400);
            buttonCash.Name = "buttonCash";
            buttonCash.Size = new Size(75, 23);
            buttonCash.TabIndex = 53;
            buttonCash.Text = " Cash";
            buttonCash.UseVisualStyleBackColor = true;
            buttonCash.Click += buttonCash_Click;
            // 
            // buttonBack
            // 
            buttonBack.ImageAlign = ContentAlignment.BottomCenter;
            buttonBack.Location = new Point(713, 384);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 23);
            buttonBack.TabIndex = 54;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonFinnance
            // 
            buttonFinnance.ImageAlign = ContentAlignment.BottomCenter;
            buttonFinnance.Location = new Point(409, 371);
            buttonFinnance.Name = "buttonFinnance";
            buttonFinnance.Size = new Size(75, 23);
            buttonFinnance.TabIndex = 55;
            buttonFinnance.Text = "Finance";
            buttonFinnance.UseVisualStyleBackColor = true;
            buttonFinnance.Click += buttonFinnance_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(423, 336);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 56;
            label1.Text = "Payment Method";
            // 
            // Camry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(buttonFinnance);
            Controls.Add(buttonBack);
            Controls.Add(buttonCash);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Camry";
            Text = "Camry";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private RichTextBox richTextBox1;
        private Button buttonCash;
        private Button buttonBack;
        private Button buttonFinnance;
        private Label label1;
    }
}