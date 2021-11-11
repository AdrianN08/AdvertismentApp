using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace AdvertisementApp
{
    public partial class FrmMain : Form
    {
        public string sqlconnectionString = ConfigurationManager.ConnectionStrings["DBC"].ConnectionString;
        SqlConnection con;
        public static string userLoggedIn = "";
        public static int userLoggedInId;

        public FrmMain()
        {
            con = new SqlConnection(sqlconnectionString);
            InitializeComponent();
            GetAllAdverts();
            GetAllCategorys();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT * FROM Users WHERE UserName=@UserName AND Password=@Password";

            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@UserName", tbxUserName.Text);
                cmd.Parameters.AddWithValue("@Password", tbxPassword.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cmd.ExecuteNonQuery();
                if (dt.Rows.Count > 0)
                {
                    userLoggedIn = tbxUserName.Text;
                    userLoggedInId = int.Parse(dt.Rows[0][0].ToString());
                    FrmUserOnline frm = new FrmUserOnline();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid UserName & Password.", Text);
                }
                tbxUserName.Text = "";
                tbxPassword.Text = "";
            }
            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbxSearch.SelectedIndex > -1)
            {
                using (SqlCommand cmd = new SqlCommand("SearchAdvertOnTitleAndCategory", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CategoryId", cbxSearch.SelectedIndex + 1);
                    cmd.Parameters.AddWithValue("@UserInput", tbxSearch.Text);

                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView.DataSource = dt;
                    con.Close();
                }
            }
            else
            {
                using (SqlCommand cmd = new SqlCommand("SearchAdvertOnTitle", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserInput", tbxSearch.Text);

                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView.DataSource = dt;
                    con.Close();
                }
            }
        }

        private void GetAllAdverts()
        {
            using (SqlCommand cmd = new SqlCommand("GetAllAdverts", con))
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView.DataSource = dt;
                con.Close();
            }
        }
        private void GetAllCategorys()
        {
            using (var db = new AdvertisementDBEntities())
            {
                var categorys = from cat in db.Categorys
                                orderby cat.CategoryId ascending
                                select cat.CategoryName;
                foreach (var i in categorys)
                {
                    cbxSearch.Items.Add(i);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cbxSearch.SelectedIndex = -1;
            tbxSearch.Text = "";
            cbxSortBy.SelectedIndex = -1;
            GetAllAdverts();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow i in dataGridView.SelectedRows)
            {
                MessageBox.Show(
                "Category: " + i.Cells[0].Value.ToString() + Environment.NewLine +
                "Advert ID: " + i.Cells[1].Value.ToString() + Environment.NewLine +
                "Title: " + i.Cells[2].Value.ToString() + Environment.NewLine +
                "Description: " + i.Cells[3].Value.ToString() + Environment.NewLine +
                "Price: " + i.Cells[4].Value.ToString() + Environment.NewLine +
                "User Name: " + i.Cells[5].Value.ToString() + Environment.NewLine +
                "Publish Date: " + i.Cells[6].Value.ToString() + Environment.NewLine);
            }
        }

        private void cbxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxSortBy.SelectedIndex)
            {
                case 0:
                    this.dataGridView.Sort(this.dataGridView.Columns["Category"], ListSortDirection.Ascending);
                    break;
                case 1:
                    this.dataGridView.Sort(this.dataGridView.Columns["Price"], ListSortDirection.Ascending);
                    break;
                case 2:
                    this.dataGridView.Sort(this.dataGridView.Columns["Price"], ListSortDirection.Descending);
                    break;
                case 3:
                    this.dataGridView.Sort(this.dataGridView.Columns["PublishDate"], ListSortDirection.Ascending);
                    break;
                case 4:
                    this.dataGridView.Sort(this.dataGridView.Columns["PublishDate"], ListSortDirection.Descending);
                    break;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegisterUser frm = new FrmRegisterUser();
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetAllAdverts();
        }
    }
}
