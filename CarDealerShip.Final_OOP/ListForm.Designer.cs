namespace CarDealerShip.Final_OOP
{
    partial class ListForm
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
            buttonView = new Button();
            datagridviewClient = new DataGridView();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)datagridviewClient).BeginInit();
            SuspendLayout();
            // 
            // buttonView
            // 
            buttonView.Location = new Point(256, 306);
            buttonView.Name = "buttonView";
            buttonView.Size = new Size(75, 23);
            buttonView.TabIndex = 0;
            buttonView.Text = "View";
            buttonView.UseVisualStyleBackColor = true;
          
            // 
            // datagridviewClient
            // 
            datagridviewClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridviewClient.Location = new Point(225, 92);
            datagridviewClient.Name = "datagridviewClient";
            datagridviewClient.Size = new Size(434, 173);
            datagridviewClient.TabIndex = 1;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(384, 306);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Delete Client";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(491, 306);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 23);
            buttonUpdate.TabIndex = 3;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // ListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonDelete);
            Controls.Add(datagridviewClient);
            Controls.Add(buttonView);
            Name = "ListForm";
            Text = "ListForm";
            ((System.ComponentModel.ISupportInitialize)datagridviewClient).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonView;
        private DataGridView datagridviewClient;
        private Button buttonDelete;
        private Button buttonUpdate;
    }
}