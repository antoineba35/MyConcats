namespace MyContact
{
    partial class AddNewGroupWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.TB_GroupName = new System.Windows.Forms.TextBox();
            this.BT_AddGroupe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du groupe :";
            // 
            // TB_GroupName
            // 
            this.TB_GroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_GroupName.Location = new System.Drawing.Point(16, 33);
            this.TB_GroupName.Name = "TB_GroupName";
            this.TB_GroupName.Size = new System.Drawing.Size(377, 29);
            this.TB_GroupName.TabIndex = 1;
            // 
            // BT_AddGroupe
            // 
            this.BT_AddGroupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_AddGroupe.Location = new System.Drawing.Point(37, 82);
            this.BT_AddGroupe.Name = "BT_AddGroupe";
            this.BT_AddGroupe.Size = new System.Drawing.Size(324, 35);
            this.BT_AddGroupe.TabIndex = 2;
            this.BT_AddGroupe.Text = "Ajouter un groupe";
            this.BT_AddGroupe.UseVisualStyleBackColor = true;
            this.BT_AddGroupe.Click += new System.EventHandler(this.BT_AddGroupe_Click);
            // 
            // AddNewGroupWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 129);
            this.Controls.Add(this.BT_AddGroupe);
            this.Controls.Add(this.TB_GroupName);
            this.Controls.Add(this.label1);
            this.Name = "AddNewGroupWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter un groupe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_GroupName;
        private System.Windows.Forms.Button BT_AddGroupe;
    }
}