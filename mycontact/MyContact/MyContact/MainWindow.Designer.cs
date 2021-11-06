namespace MyContact
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.PNL_Left = new System.Windows.Forms.Panel();
            this.Group_search = new System.Windows.Forms.GroupBox();
            this.TB_Search = new System.Windows.Forms.TextBox();
            this.Group_Contact_Liste = new System.Windows.Forms.GroupBox();
            this.BT_AddContact = new System.Windows.Forms.Button();
            this.LB_Contacts = new System.Windows.Forms.ListBox();
            this.CB_Group = new System.Windows.Forms.ComboBox();
            this.BT_DeleteContact = new System.Windows.Forms.Button();
            this.PNL_Right = new System.Windows.Forms.Panel();
            this.PB_Favorite = new System.Windows.Forms.PictureBox();
            this.LB_Ville = new System.Windows.Forms.Label();
            this.PB_ContactPhoto = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LB_Adress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LB_Tel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_Email = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_Name = new System.Windows.Forms.Label();
            this.LB_Group = new System.Windows.Forms.Label();
            this.CB_Fav = new System.Windows.Forms.CheckBox();
            this.PNL_Left.SuspendLayout();
            this.Group_search.SuspendLayout();
            this.Group_Contact_Liste.SuspendLayout();
            this.PNL_Right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Favorite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ContactPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // PNL_Left
            // 
            this.PNL_Left.Controls.Add(this.Group_search);
            this.PNL_Left.Location = new System.Drawing.Point(3, 2);
            this.PNL_Left.Name = "PNL_Left";
            this.PNL_Left.Size = new System.Drawing.Size(221, 435);
            this.PNL_Left.TabIndex = 0;
            // 
            // Group_search
            // 
            this.Group_search.Controls.Add(this.TB_Search);
            this.Group_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Group_search.Location = new System.Drawing.Point(0, 367);
            this.Group_search.Name = "Group_search";
            this.Group_search.Size = new System.Drawing.Size(221, 68);
            this.Group_search.TabIndex = 0;
            this.Group_search.TabStop = false;
            this.Group_search.Text = "Rechercher :";
            // 
            // TB_Search
            // 
            this.TB_Search.Location = new System.Drawing.Point(7, 26);
            this.TB_Search.Name = "TB_Search";
            this.TB_Search.Size = new System.Drawing.Size(208, 26);
            this.TB_Search.TabIndex = 0;
            this.TB_Search.TextChanged += new System.EventHandler(this.TB_Search_TextChanged);
            // 
            // Group_Contact_Liste
            // 
            this.Group_Contact_Liste.Controls.Add(this.BT_AddContact);
            this.Group_Contact_Liste.Controls.Add(this.LB_Contacts);
            this.Group_Contact_Liste.Controls.Add(this.CB_Group);
            this.Group_Contact_Liste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Group_Contact_Liste.Location = new System.Drawing.Point(3, 10);
            this.Group_Contact_Liste.Name = "Group_Contact_Liste";
            this.Group_Contact_Liste.Size = new System.Drawing.Size(221, 362);
            this.Group_Contact_Liste.TabIndex = 0;
            this.Group_Contact_Liste.TabStop = false;
            this.Group_Contact_Liste.Text = "Mes contacts";
            // 
            // BT_AddContact
            // 
            this.BT_AddContact.Location = new System.Drawing.Point(9, 328);
            this.BT_AddContact.Name = "BT_AddContact";
            this.BT_AddContact.Size = new System.Drawing.Size(206, 30);
            this.BT_AddContact.TabIndex = 3;
            this.BT_AddContact.Text = "Ajouter";
            this.BT_AddContact.UseVisualStyleBackColor = true;
            this.BT_AddContact.Click += new System.EventHandler(this.BT_AddContact_Click);
            // 
            // LB_Contacts
            // 
            this.LB_Contacts.FormattingEnabled = true;
            this.LB_Contacts.ItemHeight = 20;
            this.LB_Contacts.Location = new System.Drawing.Point(4, 61);
            this.LB_Contacts.Name = "LB_Contacts";
            this.LB_Contacts.Size = new System.Drawing.Size(211, 264);
            this.LB_Contacts.Sorted = true;
            this.LB_Contacts.TabIndex = 1;
            this.LB_Contacts.SelectedIndexChanged += new System.EventHandler(this.LB_Contacts_SelectedIndexChanged);
            // 
            // CB_Group
            // 
            this.CB_Group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Group.FormattingEnabled = true;
            this.CB_Group.Location = new System.Drawing.Point(7, 26);
            this.CB_Group.Name = "CB_Group";
            this.CB_Group.Size = new System.Drawing.Size(208, 28);
            this.CB_Group.TabIndex = 0;
            this.CB_Group.SelectedIndexChanged += new System.EventHandler(this.CB_Group_SelectedIndexChanged);
            // 
            // BT_DeleteContact
            // 
            this.BT_DeleteContact.BackColor = System.Drawing.Color.Transparent;
            this.BT_DeleteContact.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_DeleteContact.BackgroundImage")));
            this.BT_DeleteContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_DeleteContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_DeleteContact.Location = new System.Drawing.Point(3, 232);
            this.BT_DeleteContact.Name = "BT_DeleteContact";
            this.BT_DeleteContact.Size = new System.Drawing.Size(38, 38);
            this.BT_DeleteContact.TabIndex = 2;
            this.BT_DeleteContact.UseVisualStyleBackColor = false;
            this.BT_DeleteContact.Click += new System.EventHandler(this.BT_DeleteContact_Click);
            // 
            // PNL_Right
            // 
            this.PNL_Right.Controls.Add(this.PB_Favorite);
            this.PNL_Right.Controls.Add(this.LB_Ville);
            this.PNL_Right.Controls.Add(this.PB_ContactPhoto);
            this.PNL_Right.Controls.Add(this.BT_DeleteContact);
            this.PNL_Right.Controls.Add(this.label7);
            this.PNL_Right.Controls.Add(this.LB_Adress);
            this.PNL_Right.Controls.Add(this.label5);
            this.PNL_Right.Controls.Add(this.LB_Tel);
            this.PNL_Right.Controls.Add(this.label3);
            this.PNL_Right.Controls.Add(this.LB_Email);
            this.PNL_Right.Controls.Add(this.label1);
            this.PNL_Right.Controls.Add(this.LB_Name);
            this.PNL_Right.Controls.Add(this.LB_Group);
            this.PNL_Right.Location = new System.Drawing.Point(231, 2);
            this.PNL_Right.Name = "PNL_Right";
            this.PNL_Right.Size = new System.Drawing.Size(307, 466);
            this.PNL_Right.TabIndex = 1;
            // 
            // PB_Favorite
            // 
            this.PB_Favorite.Image = global::MyContact.Properties.Resources.Star___No_favorite;
            this.PB_Favorite.Location = new System.Drawing.Point(47, 232);
            this.PB_Favorite.Name = "PB_Favorite";
            this.PB_Favorite.Size = new System.Drawing.Size(38, 38);
            this.PB_Favorite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Favorite.TabIndex = 11;
            this.PB_Favorite.TabStop = false;
            this.PB_Favorite.Click += new System.EventHandler(this.PB_Favorite_Click);
            // 
            // LB_Ville
            // 
            this.LB_Ville.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Ville.Location = new System.Drawing.Point(85, 421);
            this.LB_Ville.Name = "LB_Ville";
            this.LB_Ville.Size = new System.Drawing.Size(214, 21);
            this.LB_Ville.TabIndex = 10;
            this.LB_Ville.Text = "Paris";
            this.LB_Ville.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PB_ContactPhoto
            // 
            this.PB_ContactPhoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB_ContactPhoto.BackgroundImage")));
            this.PB_ContactPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_ContactPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_ContactPhoto.Location = new System.Drawing.Point(7, 0);
            this.PB_ContactPhoto.Name = "PB_ContactPhoto";
            this.PB_ContactPhoto.Size = new System.Drawing.Size(296, 229);
            this.PB_ContactPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_ContactPhoto.TabIndex = 0;
            this.PB_ContactPhoto.TabStop = false;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ville :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LB_Adress
            // 
            this.LB_Adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Adress.Location = new System.Drawing.Point(85, 386);
            this.LB_Adress.Name = "LB_Adress";
            this.LB_Adress.Size = new System.Drawing.Size(214, 21);
            this.LB_Adress.TabIndex = 8;
            this.LB_Adress.Text = "1 rue de jenesaispasquoi";
            this.LB_Adress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Adresse :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LB_Tel
            // 
            this.LB_Tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Tel.Location = new System.Drawing.Point(85, 349);
            this.LB_Tel.Name = "LB_Tel";
            this.LB_Tel.Size = new System.Drawing.Size(214, 21);
            this.LB_Tel.TabIndex = 6;
            this.LB_Tel.Text = "06 xx xx xx xx";
            this.LB_Tel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tel :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LB_Email
            // 
            this.LB_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Email.Location = new System.Drawing.Point(85, 312);
            this.LB_Email.Name = "LB_Email";
            this.LB_Email.Size = new System.Drawing.Size(214, 21);
            this.LB_Email.TabIndex = 4;
            this.LB_Email.Text = "exemple@jaimail.fr";
            this.LB_Email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LB_Name
            // 
            this.LB_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Name.Location = new System.Drawing.Point(3, 278);
            this.LB_Name.Name = "LB_Name";
            this.LB_Name.Size = new System.Drawing.Size(304, 22);
            this.LB_Name.TabIndex = 2;
            this.LB_Name.Text = "Nom Prénom";
            this.LB_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_Group
            // 
            this.LB_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Group.Location = new System.Drawing.Point(190, 232);
            this.LB_Group.Name = "LB_Group";
            this.LB_Group.Size = new System.Drawing.Size(109, 21);
            this.LB_Group.TabIndex = 1;
            this.LB_Group.Text = "Groupe";
            this.LB_Group.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CB_Fav
            // 
            this.CB_Fav.AutoSize = true;
            this.CB_Fav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Fav.Location = new System.Drawing.Point(10, 439);
            this.CB_Fav.Name = "CB_Fav";
            this.CB_Fav.Size = new System.Drawing.Size(157, 24);
            this.CB_Fav.TabIndex = 2;
            this.CB_Fav.Text = "Afficher les favoris";
            this.CB_Fav.UseVisualStyleBackColor = true;
            this.CB_Fav.CheckedChanged += new System.EventHandler(this.CB_Fav_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 468);
            this.Controls.Add(this.CB_Fav);
            this.Controls.Add(this.Group_Contact_Liste);
            this.Controls.Add(this.PNL_Left);
            this.Controls.Add(this.PNL_Right);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyContacts";
            this.PNL_Left.ResumeLayout(false);
            this.Group_search.ResumeLayout(false);
            this.Group_search.PerformLayout();
            this.Group_Contact_Liste.ResumeLayout(false);
            this.PNL_Right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Favorite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ContactPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Left;
        private System.Windows.Forms.GroupBox Group_Contact_Liste;
        private System.Windows.Forms.ComboBox CB_Group;
        private System.Windows.Forms.GroupBox Group_search;
        private System.Windows.Forms.TextBox TB_Search;
        private System.Windows.Forms.Button BT_DeleteContact;
        private System.Windows.Forms.ListBox LB_Contacts;
        private System.Windows.Forms.Panel PNL_Right;
        private System.Windows.Forms.Label LB_Ville;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LB_Adress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LB_Tel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LB_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_Name;
        private System.Windows.Forms.Label LB_Group;
        private System.Windows.Forms.PictureBox PB_ContactPhoto;
        private System.Windows.Forms.Button BT_AddContact;
        private System.Windows.Forms.PictureBox PB_Favorite;
        private System.Windows.Forms.CheckBox CB_Fav;
    }
}

