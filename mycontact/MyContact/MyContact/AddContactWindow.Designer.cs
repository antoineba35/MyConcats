namespace MyContact
{
    partial class AddContactWindow
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
            this.components = new System.ComponentModel.Container();
            this.PB_ContactPhoto = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT_AddGroupe = new System.Windows.Forms.Button();
            this.CB_Group = new System.Windows.Forms.ComboBox();
            this.TB_Ville = new System.Windows.Forms.TextBox();
            this.TB_Adresse = new System.Windows.Forms.TextBox();
            this.TB_Tel = new System.Windows.Forms.TextBox();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.TB_Nom = new System.Windows.Forms.TextBox();
            this.TB_Prenom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_Add = new System.Windows.Forms.Button();
            this.BT_ChooseImage = new System.Windows.Forms.Button();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.CM_Group = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MI_DeleteGroup = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ContactPhoto)).BeginInit();
            this.panel1.SuspendLayout();
            this.CM_Group.SuspendLayout();
            this.SuspendLayout();
            // 
            // PB_ContactPhoto
            // 
            this.PB_ContactPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_ContactPhoto.Location = new System.Drawing.Point(15, 12);
            this.PB_ContactPhoto.Name = "PB_ContactPhoto";
            this.PB_ContactPhoto.Size = new System.Drawing.Size(296, 229);
            this.PB_ContactPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_ContactPhoto.TabIndex = 1;
            this.PB_ContactPhoto.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BT_AddGroupe);
            this.panel1.Controls.Add(this.CB_Group);
            this.panel1.Controls.Add(this.TB_Ville);
            this.panel1.Controls.Add(this.TB_Adresse);
            this.panel1.Controls.Add(this.TB_Tel);
            this.panel1.Controls.Add(this.TB_Email);
            this.panel1.Controls.Add(this.TB_Nom);
            this.panel1.Controls.Add(this.TB_Prenom);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 247);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 269);
            this.panel1.TabIndex = 2;
            // 
            // BT_AddGroupe
            // 
            this.BT_AddGroupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_AddGroupe.Location = new System.Drawing.Point(207, 231);
            this.BT_AddGroupe.Name = "BT_AddGroupe";
            this.BT_AddGroupe.Size = new System.Drawing.Size(85, 27);
            this.BT_AddGroupe.TabIndex = 28;
            this.BT_AddGroupe.Text = "Ajouter";
            this.BT_AddGroupe.UseVisualStyleBackColor = true;
            this.BT_AddGroupe.Click += new System.EventHandler(this.BT_AddGroupe_Click);
            // 
            // CB_Group
            // 
            this.CB_Group.ContextMenuStrip = this.CM_Group;
            this.CB_Group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Group.FormattingEnabled = true;
            this.CB_Group.Location = new System.Drawing.Point(86, 230);
            this.CB_Group.Name = "CB_Group";
            this.CB_Group.Size = new System.Drawing.Size(114, 28);
            this.CB_Group.TabIndex = 27;
            // 
            // TB_Ville
            // 
            this.TB_Ville.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Ville.Location = new System.Drawing.Point(85, 193);
            this.TB_Ville.Name = "TB_Ville";
            this.TB_Ville.Size = new System.Drawing.Size(207, 26);
            this.TB_Ville.TabIndex = 26;
            // 
            // TB_Adresse
            // 
            this.TB_Adresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Adresse.Location = new System.Drawing.Point(85, 157);
            this.TB_Adresse.Name = "TB_Adresse";
            this.TB_Adresse.Size = new System.Drawing.Size(207, 26);
            this.TB_Adresse.TabIndex = 25;
            // 
            // TB_Tel
            // 
            this.TB_Tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Tel.Location = new System.Drawing.Point(85, 120);
            this.TB_Tel.Name = "TB_Tel";
            this.TB_Tel.Size = new System.Drawing.Size(207, 26);
            this.TB_Tel.TabIndex = 24;
            // 
            // TB_Email
            // 
            this.TB_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Email.Location = new System.Drawing.Point(85, 84);
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(207, 26);
            this.TB_Email.TabIndex = 23;
            // 
            // TB_Nom
            // 
            this.TB_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Nom.Location = new System.Drawing.Point(85, 50);
            this.TB_Nom.Name = "TB_Nom";
            this.TB_Nom.Size = new System.Drawing.Size(207, 26);
            this.TB_Nom.TabIndex = 22;
            // 
            // TB_Prenom
            // 
            this.TB_Prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Prenom.Location = new System.Drawing.Point(85, 10);
            this.TB_Prenom.Name = "TB_Prenom";
            this.TB_Prenom.Size = new System.Drawing.Size(207, 26);
            this.TB_Prenom.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Groupe :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nom :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Prénom :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ville :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Adresse :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tel :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Email :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BT_Add
            // 
            this.BT_Add.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BT_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Add.Location = new System.Drawing.Point(0, 522);
            this.BT_Add.Name = "BT_Add";
            this.BT_Add.Size = new System.Drawing.Size(323, 34);
            this.BT_Add.TabIndex = 3;
            this.BT_Add.Text = "Ajouter un contact";
            this.BT_Add.UseVisualStyleBackColor = true;
            this.BT_Add.Click += new System.EventHandler(this.BT_Add_Click);
            // 
            // BT_ChooseImage
            // 
            this.BT_ChooseImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_ChooseImage.Location = new System.Drawing.Point(15, 210);
            this.BT_ChooseImage.Name = "BT_ChooseImage";
            this.BT_ChooseImage.Size = new System.Drawing.Size(296, 31);
            this.BT_ChooseImage.TabIndex = 4;
            this.BT_ChooseImage.Text = "Choisir une image";
            this.BT_ChooseImage.UseVisualStyleBackColor = true;
            this.BT_ChooseImage.Click += new System.EventHandler(this.BT_ChooseImage_Click);
            // 
            // OFD
            // 
            this.OFD.Filter = "(Fichier PNG)|*.png|(Fichier JPEG)|*.jpeg";
            this.OFD.Title = "Sélectionner une image";
            // 
            // CM_Group
            // 
            this.CM_Group.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_DeleteGroup});
            this.CM_Group.Name = "CM_Group";
            this.CM_Group.Size = new System.Drawing.Size(130, 26);
            // 
            // MI_DeleteGroup
            // 
            this.MI_DeleteGroup.Name = "MI_DeleteGroup";
            this.MI_DeleteGroup.Size = new System.Drawing.Size(129, 22);
            this.MI_DeleteGroup.Text = "Supprimer";
            this.MI_DeleteGroup.Click += new System.EventHandler(this.MI_DeleteGroup_Click);
            // 
            // AddContactWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 556);
            this.Controls.Add(this.BT_ChooseImage);
            this.Controls.Add(this.BT_Add);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PB_ContactPhoto);
            this.Name = "AddContactWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter un contact";
            ((System.ComponentModel.ISupportInitialize)(this.PB_ContactPhoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.CM_Group.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_ContactPhoto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Group;
        private System.Windows.Forms.TextBox TB_Ville;
        private System.Windows.Forms.TextBox TB_Adresse;
        private System.Windows.Forms.TextBox TB_Tel;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.TextBox TB_Nom;
        private System.Windows.Forms.TextBox TB_Prenom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BT_Add;
        private System.Windows.Forms.Button BT_ChooseImage;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.Button BT_AddGroupe;
        private System.Windows.Forms.ContextMenuStrip CM_Group;
        private System.Windows.Forms.ToolStripMenuItem MI_DeleteGroup;
    }
}