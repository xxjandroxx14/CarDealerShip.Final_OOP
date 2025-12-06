namespace CarDealerShip.Final_OOP.Honda.Sedan
{
    partial class ACCORD
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
            buttonBack = new Button();
            buttonCash = new Button();
            buttonFinance = new Button();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.ImageAlign = ContentAlignment.BottomCenter;
            buttonBack.Location = new Point(356, 344);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 23);
            buttonBack.TabIndex = 35;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonCash
            // 
            buttonCash.ImageAlign = ContentAlignment.BottomCenter;
            buttonCash.Location = new Point(594, 344);
            buttonCash.Name = "buttonCash";
            buttonCash.Size = new Size(75, 23);
            buttonCash.TabIndex = 36;
            buttonCash.Text = "Cash";
            buttonCash.UseVisualStyleBackColor = true;
            // 
            // buttonFinance
            // 
            buttonFinance.ImageAlign = ContentAlignment.BottomCenter;
            buttonFinance.Location = new Point(486, 344);
            buttonFinance.Name = "buttonFinance";
            buttonFinance.Size = new Size(75, 23);
            buttonFinance.TabIndex = 37;
            buttonFinance.Text = "Finance";
            buttonFinance.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(489, 36);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(254, 266);
            richTextBox1.TabIndex = 38;
            richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(118, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(118, 191);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.TabIndex = 40;
            pictureBox2.TabStop = false;
            // 
            // ACCORD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox1);
            Controls.Add(buttonFinance);
            Controls.Add(buttonCash);
            Controls.Add(buttonBack);
            Name = "ACCORD";
            Text = "ACCORD";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonBack;
        private Button buttonCash;
        private Button buttonFinance;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}