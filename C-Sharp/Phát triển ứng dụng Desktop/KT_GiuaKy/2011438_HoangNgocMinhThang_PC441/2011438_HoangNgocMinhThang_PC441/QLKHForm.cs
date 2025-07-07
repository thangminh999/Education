using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2011438_HoangNgocMinhThang_PC441
{
    public partial class QLKHForm : Form
    {
        public QLKHForm()
        {
            InitializeComponent();
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=PC441;Initial Catalog=QLBanHang;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = "DELETE FROM KhachHang" +
                "WHERE MaKH = " + txtMaKH.Text;

            sqlConnection.Open();

            int numofRowsEffected = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            if (numofRowsEffected == 1)
            {
                ListViewItem item = lvKhachHang.SelectedItems[0];
                lvKhachHang.Items.Remove(item);

                txtMaKH.Text = "";
                txtTenKH.Text = "";
                mtxtSoDT.Text = "";
                txtTimKiem.Text = "";

                btnLuu.Enabled = false;
                btnMacDinh.Enabled = false;

                MessageBox.Show("Xóa nhập liệu thành công");
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra, hãy thử lại !!");
            }
        }

        private void lvKhachHang_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvKhachHang.SelectedItems[0];

            txtMaKH.Text = item.Text;
            txtTenKH.Text = item.SubItems[1].Text;
            mtxtSoDT.Text = item.SubItems[2].Text;
            txtTimKiem.Text = item.SubItems[3].Text;

            btnLuu.Enabled = false;
            btnMacDinh.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=PC441;Initial Catalog=QLBanHang;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = "INSERT INTO KhachHang(TenKH, SoDienThoai)" +
                "VALUES (N'" + txtTenKH.Text + "', " + mtxtSoDT.Text + ")";

            sqlConnection.Open();

            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            if (numOfRowsEffected == 1)
            {
                MessageBox.Show("Thêm nhập liệu thành công");
                
                txtTenKH.Text = "";
                mtxtSoDT.Text = "";
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. hãy thử lại !!");
            }
        }
    }
}
