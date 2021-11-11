using System;
using System.Windows.Forms;

namespace AdvertisementApp
{
    public partial class FrmRegisterUser : Form
    {
        public FrmRegisterUser()
        {
            InitializeComponent();
            lnkLogin.Visible = false;
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            using (var db = new AdvertisementDBEntities())
            {
                try
                {
                    var newUser = db.NewUser(tbxUserName.Text, tbxPassword.Text, tbxEmail.Text, tbxAddress.Text, tbxPhoneNr.Text);                   
                    db.SaveChanges();
                    lbMsg.Text = "New User " + tbxUserName.Text + " Is Succesfully Registered";
                    foreach (Control c in this.Controls)
                    {
                        if (c is TextBox)
                        {
                            c.Text = "";
                        }
                    }
                    lnkLogin.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Text);

                }
            }
        }
        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }
    }
}
