using System;
using System.Windows.Forms;
using System.Drawing;

namespace MyContact
{
    public partial class AddContactWindow : Form
    {
        public AddContactWindow()
        {
            InitializeComponent();
            LoadGroup();
        }

        private void LoadGroup()
        {
            this.CB_Group.Items.Clear();
            this.CB_Group.Items.AddRange(Global.contactsGroup.ToArray());

            if(this.CB_Group.Items.Count > 0)
            {
                this.CB_Group.SelectedIndex = 0;
            }
        }

        private void BT_Add_Click(object sender, EventArgs e)
        {
            // récupérer les champs saisies
            string lastName = this.TB_Nom.Text;
            string firstName = this.TB_Prenom.Text;
            string email = this.TB_Email.Text;
            string tel = this.TB_Tel.Text;
            string address = this.TB_Adresse.Text;
            string city = this.TB_Ville.Text;
            Group group = (Group)this.CB_Group.SelectedItem;
            Image photo = this.PB_ContactPhoto.Image;

            // vérification des champs
            if(CheckInputs(firstName, lastName, email, tel, address, city, group))
            {
                Contact contact = new Contact(firstName, lastName, email, tel, address, city, photo, false);

                // ajout du contact dans le groupe
                group.Contacts.Add(contact);

                // fermer la fenetre
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Veuillez entrer tous les champs !", "MyContact", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // création d'un nouveau contact

            
        }

        private bool CheckInputs(string firstName, string lastName, string email, string tel, string address, string city, Group group)
        {
            return !string.IsNullOrEmpty(firstName)
                && !string.IsNullOrEmpty(lastName)
                && !string.IsNullOrEmpty(email)
                && !string.IsNullOrEmpty(tel)
                && !string.IsNullOrEmpty(address)
                && !string.IsNullOrEmpty(city)
                && group != null;
        }

        private void BT_ChooseImage_Click(object sender, EventArgs e)
        {
            DialogResult dr =  this.OFD.ShowDialog();
            if(dr == DialogResult.OK)
            {
                this.PB_ContactPhoto.ImageLocation = this.OFD.FileName;
            }
        }

        private void BT_AddGroupe_Click(object sender, EventArgs e)
        {
            AddNewGroupWindow agw = new AddNewGroupWindow();
            if(agw.ShowDialog() == DialogResult.OK)
            {
                if(agw.GroupToAdd != null)
                {
                    Global.AddGroup(agw.GroupToAdd);

                    this.CB_Group.Items.Add(agw.GroupToAdd);
                    this.CB_Group.SelectedItem = agw.GroupToAdd;
                }
            }
        }

        private void MI_DeleteGroup_Click(object sender, EventArgs e)
        {
            if(this.CB_Group.SelectedIndex >= 0)
            {
                Group group = (Group)this.CB_Group.SelectedItem;

                if(group.Contacts.Count > 0)
                {
                    DialogResult dr = MessageBox.Show("Ce groupe contient des contacts qui vont être supprimés ! \n Etes vous sur de vouloir le supprimer", "MyContacts",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if(dr == DialogResult.No)
                    {
                        return;
                    }
                }

                Global.DeleteGroup(group);

                this.CB_Group.Items.Remove(group);

                if(this.CB_Group.Items.Count >= 0)
                {
                    this.CB_Group.SelectedIndex = 0;
                }
            }
        }
    }
}
