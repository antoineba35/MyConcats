using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace MyContact
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            Global.contactsGroup = SaveManager.Open();
            LoadGroup();
        }

        public void LoadGroup()
        {
            this.CB_Group.Items.Clear();
            this.CB_Group.Items.Add("Tout");
            this.CB_Group.Items.AddRange(Global.contactsGroup.ToArray());
            this.CB_Group.SelectedIndex = 0;
        }

        private void UpdateContacts()
        {
            int selectedIndex = this.CB_Group.SelectedIndex;
            if(selectedIndex == 0)
            {
                // afficher tous les contacts
                ShowAllContacts();
            }
            else if(selectedIndex > 0)
            {
                // afficher les contacts du groupe selectionné
                Group group = (Group)this.CB_Group.SelectedItem;
                ShowContactsOf(group);
            }

            if(this.LB_Contacts.Items.Count > 0)
            {
                this.LB_Contacts.SelectedIndex = 0;
            }
            else
            {
                ClearInfos();
            }
        }

        private void ShowContactsOf(Group group)
        {
            if(this.CB_Fav.Checked)
                this.CB_Fav.Checked = false;
                
            this.LB_Contacts.Items.Clear();
            this.LB_Contacts.Items.AddRange(group.Contacts.ToArray());
        }

        private void ShowAllContacts()
        {
            this.LB_Contacts.Items.Clear();

            if(!this.CB_Fav.Checked)
            {
                foreach (Group group in Global.contactsGroup)
                {
                    this.LB_Contacts.Items.AddRange(group.Contacts.ToArray());
                }
            }
            else
            {
                List<Contact> favoritesContacts = new List<Contact>();
                foreach(Group group in Global.contactsGroup)
                {
                    List<Contact> favoritesOfGroup = group.Contacts.FindAll(c => c.Favorite);
                    favoritesContacts.AddRange(favoritesOfGroup);
                }
                this.LB_Contacts.Items.AddRange(favoritesContacts.ToArray());
            }
        }

        private void BT_AddContact_Click(object sender, EventArgs e)
        {
            AddContactWindow acw = new AddContactWindow();
            DialogResult dr = acw.ShowDialog();

            if(dr == DialogResult.OK)
            {
                // mettre a jour la liste des contacts
                UpdateContacts();

                // sauvegarder les données
                SaveManager.Save(Global.contactsGroup);
            }
        }

        private void CB_Group_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateContacts();
        }

        private void LB_Contacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contact contact = (Contact)this.LB_Contacts.SelectedItem;
            if(contact != null)
            {
                ShowInfoOf(contact);
            }
        }

        private void ShowInfoOf(Contact contact)
        {
            // on enlève les infos du contacts précédant
            ClearInfos();

            //on affiche les nouveaux
            Image imageToShow;
            if (contact.Photo != null)
                imageToShow = contact.Photo;
            else
                imageToShow = Properties.Resources._2044278_account_user_interface_profile_icon;

            this.PB_ContactPhoto.Image = imageToShow;
            this.LB_Group.Text = GetGroupOf(contact).Name;
            this.LB_Name.Text = contact.ToString();
            this.LB_Email.Text = contact.Email;
            this.LB_Tel.Text = contact.Tel;
            this.LB_Adress.Text = contact.Address;
            this.LB_Ville.Text = contact.City;
            UpdateFavorite(contact.Favorite);
        }

        private void ClearInfos()
        {
            this.PB_ContactPhoto.Image = Properties.Resources._2044278_account_user_interface_profile_icon;
            this.LB_Group.Text = "";
            this.LB_Name.Text = "";
            this.LB_Email.Text = "";
            this.LB_Tel.Text = "";
            this.LB_Adress.Text = "";
            this.LB_Ville.Text = "";
            UpdateFavorite(false);
        }

        private Group GetGroupOf(Contact contact)
        {
            return Global.contactsGroup.Find(group => group.Contacts.Contains(contact));
        }

        private void BT_DeleteContact_Click(object sender, EventArgs e)
        {
            Contact contact = (Contact)this.LB_Contacts.SelectedItem;
            Group group = GetGroupOf(contact);

            if(group != null && contact != null)
            {
                DialogResult dr = MessageBox.Show("Etes vous sur de vouloir supprimer ce contact ?",
                    "MyContacts", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);
                if(dr == DialogResult.Yes)
                {
                    group.Contacts.Remove(contact);
                    UpdateContacts();
                    SaveManager.Save(Global.contactsGroup);
                }
            }
        }

        // Rechercher un contact
        private void TB_Search_TextChanged(object sender, EventArgs e)
        {
            if(this.CB_Fav.Checked)
            {
                this.CB_Fav.Checked = false;
            }
            // On récupère la saisie de l'utilisateur (la chaine à rechercher)
            string search = this.TB_Search.Text.ToLower();

            // Si cette saisie est vide alors...
            if (search.Length <= 0)
            {
                // On revient à la normal en affichant tout les contact du groupe séectionné
                UpdateContacts();
                // Et on quitte la méthode
                return;
            }

            // On vide la liste de contacts
            this.LB_Contacts.Items.Clear();

            // On parcours tout les groupes
            foreach (Group g in Global.contactsGroup)
            {
                // On parcours la liste de contacts du groupe courant
                foreach (Contact c in g.Contacts)
                {
                    // On récupère le nom et prénom du contact courant en minuscule (ToLower)
                    string cName = c.ToString().ToLower();

                    // Si le nom complet du contact contient la chaine recherché alors...
                    if (cName.Contains(search))
                    {
                        // On ajoute le contact à la liste
                        this.LB_Contacts.Items.Add(c);
                    }
                }
            }
        }

        private void PB_Favorite_Click(object sender, EventArgs e)
        {
            Contact contact = (Contact)this.LB_Contacts.SelectedItem;
            contact.Favorite = !contact.Favorite;

            UpdateFavorite(contact.Favorite);

            SaveManager.Save(Global.contactsGroup);
        }

        private void UpdateFavorite(bool favorite)
        {
            if(favorite)
            {
                this.PB_Favorite.Image = Properties.Resources.Star___favorie;
            }
            else
            {
                this.PB_Favorite.Image = Properties.Resources.Star___No_favorite;
            }
        }

        private void CB_Fav_CheckedChanged(object sender, EventArgs e)
        {
            ShowAllContacts();
        }

    }
}
