using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTapDe3
{
    public partial class ThemLoai : Form
    {
        //private string _connectionString = "DESKTOP-PMVRKKQ";
        private string _connectionString = @"Data Source=DESKTOP-PMVRKKQ;Initial Catalog=QLBanHang;Integrated Security=True";
        public ThemLoai()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var loaiMH = GetLoaiMH();
            if(loaiMH == null)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var conn = new SqlConnection(_connectionString);
            var cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT [dbo].[LoaiMatHang] ([TenLoai]) VALUES (@TenLoai)";

            cmd.Parameters.AddWithValue("@TenLoai", this.txtTenLoaiMH.Text);

            conn.Open();
            var num = cmd.ExecuteNonQuery();
            if (num > 0)
            {
                MessageBox.Show("Thêm loại mặt hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private LoaiMatHang GetLoaiMH()
        {
            var loaiMH = new LoaiMatHang();
            //mh.MaMH = string.IsNullOrWhiteSpace(this.txtMaMH.Text) ? -1 : Convert.ToInt32(this.txtMaMH.Text);
            if (!string.IsNullOrWhiteSpace(this.txtTenLoaiMH.Text))
            {
                loaiMH.TenLoai = this.txtTenLoaiMH.Text;
            }
            else
            {
                loaiMH = null;
            }
            return loaiMH;
        }
    }
}
