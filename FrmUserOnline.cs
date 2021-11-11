using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AdvertisementApp
{
    public partial class FrmUserOnline : Form
    {
        int selectedAdvertId;
        public FrmUserOnline()
        {
            InitializeComponent();
        }
        private void FrmUserOnline_Load(object sender, EventArgs e)
        {
            lblUserName.Text += FrmMain.userLoggedIn;
            lblUserId.Text += FrmMain.userLoggedInId;
            this.Text = "Welcome " + FrmMain.userLoggedIn;
            using (var db = new AdvertisementDBEntities())
            {
                try
                {
                    RefreshDataGridView(db);
                    var categorys = from cat in db.Categorys
                                    orderby cat.CategoryId ascending
                                    select cat.CategoryName;
                    foreach (var i in categorys)
                    {
                        cbxCategory.Items.Add(i);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Text);
                }
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                //{
                //    cbxCategory.SelectedItem = dataGridView.Rows[e.RowIndex].Cells["Category"].FormattedValue.ToString();
                //    dataGridView.CurrentRow.Selected = true;
                //    tbxTitle.Text = dataGridView.Rows[e.RowIndex].Cells["Title"].FormattedValue.ToString();
                //    tbxDescription.Text = dataGridView.Rows[e.RowIndex].Cells["Description"].FormattedValue.ToString();
                //    tbxPrice.Text = dataGridView.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                //    tbxDateIn.Text = dataGridView.Rows[e.RowIndex].Cells["PublishDate"].FormattedValue.ToString();
                //    selectedAdvertId = int.Parse(dataGridView.Rows[e.RowIndex].Cells["AdvertId"].FormattedValue.ToString());
                //}
                //else return;

                foreach (DataGridViewRow i in dataGridView.SelectedRows)
                {
                    cbxCategory.SelectedItem = i.Cells[0].Value.ToString();
                    selectedAdvertId = int.Parse(i.Cells[1].Value.ToString());
                    tbxTitle.Text = i.Cells[2].Value.ToString();
                    tbxDescription.Text = i.Cells[3].Value.ToString();
                    tbxPrice.Text = i.Cells[4].Value.ToString();
                    tbxDateIn.Text = i.Cells[6].Value.ToString();                 
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var db = new AdvertisementDBEntities())
            {
                try
                {
                    if (!decimal.TryParse(tbxPrice.Text, out decimal price))
                    {
                        MessageBox.Show("Wrong format on Price input value", Text);
                    }
                    if (!DateTime.TryParse(tbxDateIn.Text, out DateTime date))
                    {
                        MessageBox.Show("Wrong format on Date input value", Text);
                    }
                    db.NewAdvert(tbxTitle.Text, tbxDescription.Text, price, date, FrmMain.userLoggedInId, cbxCategory.SelectedIndex + 1);
                    db.SaveChanges();
                    RefreshDataGridView(db);
                    ClearTbx();
                    MessageBox.Show("Successfully Added..");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Text);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var db = new AdvertisementDBEntities())
            {
                try
                {
                    Advert adToUpdate = db.Adverts.FirstOrDefault(x => x.AdvertId == selectedAdvertId);
                    adToUpdate.CategoryId = cbxCategory.SelectedIndex + 1;
                    adToUpdate.Title = tbxTitle.Text;
                    adToUpdate.Description = tbxDescription.Text;
                    adToUpdate.Price = decimal.Parse(tbxPrice.Text);
                    adToUpdate.DateIn = DateTime.Parse(tbxDateIn.Text);                   
                    db.SaveChanges();
                    RefreshDataGridView(db);
                    ClearTbx();
                    MessageBox.Show("Successfully Updated..");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Text);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var db = new AdvertisementDBEntities())
            {
                try
                {
                    Advert adToRemove = db.Adverts.FirstOrDefault(x => x.AdvertId == selectedAdvertId);
                    db.Adverts.Remove(adToRemove);
                    db.SaveChanges();
                    RefreshDataGridView(db);
                    ClearTbx();
                    MessageBox.Show("Successfully Deleted..");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Text);
                }
            }
        }

        private void RefreshDataGridView(AdvertisementDBEntities db)
        {
            var userAdverts = db.GetUserAdverts(FrmMain.userLoggedInId);
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DataSource = userAdverts;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTbx();
        }
        private void ClearTbx()
        {
            cbxCategory.SelectedIndex = -1;
            foreach (Control c in grpAdverts.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }
        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmMain.userLoggedIn = "";
            FrmMain.userLoggedInId = 0  ;
        }
    }
}
