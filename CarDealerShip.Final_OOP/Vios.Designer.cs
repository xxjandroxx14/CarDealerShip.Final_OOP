namespace CarDealerShip.Final_OOP
{
    partial class Vios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vios));
            pictureBoxVios = new PictureBox();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVios).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxVios
            // 
            pictureBoxVios.Image = (Image)resources.GetObject("pictureBoxVios.Image");
            pictureBoxVios.Location = new Point(12, 12);
            pictureBoxVios.Name = "pictureBoxVios";
            pictureBoxVios.Size = new Size(355, 201);
            pictureBoxVios.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxVios.TabIndex = 0;
            pictureBoxVios.TabStop = false;
            pictureBoxVios.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(178, 273);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Buy";
            button1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(388, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(400, 436);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Vios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(pictureBoxVios);
            Name = "Vios";
            Text = "Vios";
            ((System.ComponentModel.ISupportInitialize)pictureBoxVios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxVios;
        private Button button1;
        private RichTextBox richTextBox1;
    }
}