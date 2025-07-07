using System;
using System.Data;
using System.Data.SqlClient;
//using System.ArgumentException;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Basic_Command
{
    public partial class frmMonAn : Form
    {
        public frmMonAn()
        {
            InitializeComponent();
        }

        private void btnLayDS_Click(object sender, EventArgs e)
        {
            string connectionString = "server=.; database = RestaurantManagement1; Integrated Sercurity = true; ";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            string query = "SELECT ID, Name, Type FROM Category";
            sqlCommand.CommandText = query;
            
            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            this.DisplayCategory(sqlDataReader);

            sqlConnection.Close();
        }
        private void DisplayCategory(SqlDataReader reader)
        {
            lvCategory.Items.Clear();
            while(reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["ID"].ToString());

                lvCategory.Items.Add(item);

                item.SubItems.Add(reader["Name"].ToString());
                item.SubItems.Add(reader["Type"].ToString());
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string connectionString = "server=.; database = RestaurantManagement1; Integrated Security = true; ";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = "INSERT INTO Category(Name, [Type])" +
                "VALUES (N'" + txtTenNhom.Text + "', " + txtLoai.Text + ")";

            sqlConnection.Open();

            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            if(numOfRowsEffected == 1)
            {
                MessageBox.Show("Thêm nhóm món ăn thành công");
                //
                btnLayDS.PerformClick();
                txtTenNhom.Text = "";
                txtLoai.Text = "";
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
            }
        }

        private void lvCategory_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvCategory.SelectedItems[0];

            txtMaNhom.Text = item.Text;
            txtTenNhom.Text = item.SubItems[1].Text;
            txtLoai.Text = item.SubItems[1].Text == "0" ? "Thức uống" : "Đồ ăn";

            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = "UPDATE Category SET Name = N'" + txtTenNhom.Text +
                                                                    "', [Type] = " + txtLoai.Text +
                                                                    "WHERE ID = " + txtMaNhom.Text;

            sqlConnection.Open();

            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            if(numOfRowsEffected == 1)
            {
                ListViewItem item = lvCategory.SelectedItems[0];

                item.SubItems[1].Text = txtTenNhom.Text;
                item.SubItems[2].Text = txtLoai.Text;

                txtMaNhom.Text = "";
                txtTenNhom.Text = "";
                txtLoai.Text = "";

                btnCapNhat.Enabled = false;
                btnXoa.Enabled = false;

                MessageBox.Show("Cập nhật nhóm món ăn thành công");
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra, Vui lòng thử lại !");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string connectionString = "server=.; database = RestaurantManagement1; Integrated Security = true; ";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = "DELETE FROM Category" +
                "WHERE ID = " + txtMaNhom.Text;

            sqlConnection.Open();

            int numofRowsEffected = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            if(numofRowsEffected == 1)
            {
                ListViewItem item = lvCategory.SelectedItems[0];
                lvCategory.Items.Remove(item);

                txtMaNhom.Text = "";
                txtTenNhom.Text = "";
                txtLoai.Text = "";

                btnCapNhat.Enabled = false;
                btnXoa.Enabled = false;

                MessageBox.Show("Xóa nhóm món ăn thành công");
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại !!");
            }
        }

        private void tsmViewFood_Click(object sender, EventArgs e)
        {
            if(txtMaNhom.Text != "")
            {
                frmFood foodForm = new frmFood();
                foodForm.Show(this);
                foodForm.LoadFood(Convert.ToInt32(txtMaNhom.Text));
            }
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (lvCategory.SelectedItems.Count > 0)
                btnXoa.PerformClick();
        }
    }
}
