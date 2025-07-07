using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTapDe3
{
    public partial class QLBanHang : Form
    {
        //private string _connectionString = "DESKTOP-PMVRKKQ";
        private string _connectionString = @"Data Source=DESKTOP-TM999;Initial Catalog=QLBanHang;Integrated Security=True";
        private List<MatHang> _dsMatHang;
        private List<LoaiMatHang> _dsLoai;
        public QLBanHang()
        {
            InitializeComponent();
        }

        private void QLBanHang_Load(object sender, EventArgs e)
        {
            _dsMatHang = new List<MatHang>();
            _dsLoai = new List<LoaiMatHang>();
            GetDSLoai();
            GetDSMatHang();
            LoadListView(_dsMatHang);
        }

        private void GetDSMatHang()
        {
            var conn = new SqlConnection(_connectionString);
            var command = conn.CreateCommand();
            command.CommandText = ("SELECT * FROM MatHang");
            var sqlDataAdapter = new SqlDataAdapter(command);
            var table = new DataTable("MatHang");

            conn.Open();
            sqlDataAdapter.Fill(table);
            conn.Close();
            _dsMatHang = new List<MatHang>();
            foreach (DataRow row in table.Rows)
            {
                _dsMatHang.Add(new MatHang(row));
            }
        }

        private void GetDSLoai()
        {
            var conn = new SqlConnection(_connectionString);
            var command = conn.CreateCommand();
            command.CommandText = ("SELECT * FROM LoaiMatHang");
            var sqlDataAdapter = new SqlDataAdapter(command);
            var table = new DataTable("LoaiMatHang");

            conn.Open();
            sqlDataAdapter.Fill(table);
            conn.Close();

            _dsLoai = new List<LoaiMatHang>();
            foreach (DataRow row in table.Rows)
            {
                _dsLoai.Add(new LoaiMatHang(row));
            }

            cbbLoaiMH.DisplayMember = "TenLoai";
            cbbLoaiMH.ValueMember = "MaLoai";
            cbbLoaiMH.DataSource = _dsLoai;
        }

        private void LoadListView(List<MatHang> dsmh)
        {
            lvDSMH.Items.Clear();

            foreach (var item in dsmh)
            {
                addToListView(item);
            }
        }

        private void addToListView(MatHang mh)
        {
            string[] row = { mh.MaMH.ToString(), mh.TenMH, mh.MaLoai.ToString(), mh.SoLuong.ToString(), mh.DonGia.ToString()};
            var item = new ListViewItem(row);
            lvDSMH.Items.Add(item);
        }

        private void ThietLapThongTinMH(MatHang mh)
        {
            this.txtMaMH.Text = mh.MaMH.ToString();
            this.txtTenMH.Text = mh.TenMH;
            this.cbbLoaiMH.SelectedValue = mh.MaLoai;
            this.nudSoLuong.Value = mh.SoLuong;
            this.nudDonGia.Value = mh.DonGia;
        }

        private void lvDSMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvDSMH.SelectedItems.Count > 0)
            {
                var maMH = Convert.ToInt32(lvDSMH.SelectedItems[0].Text);
                var mh = _dsMatHang.FirstOrDefault(x => x.MaMH == maMH);
                ThietLapThongTinMH(mh);
            }
        }

        private MatHang GetMH()
        {
            var mh = new MatHang();
            //mh.MaMH = string.IsNullOrWhiteSpace(this.txtMaMH.Text) ? -1 : Convert.ToInt32(this.txtMaMH.Text);
            if (!string.IsNullOrWhiteSpace(this.txtTenMH.Text))
            {
                mh.MaMH = string.IsNullOrWhiteSpace(this.txtMaMH.Text) ? -1 : Convert.ToInt32(this.txtMaMH.Text);
                mh.TenMH = this.txtTenMH.Text;
                mh.MaLoai = Convert.ToInt32(this.cbbLoaiMH.SelectedValue);
                mh.SoLuong = Convert.ToInt32(this.nudSoLuong.Value);
                mh.DonGia = Convert.ToInt32(this.nudDonGia.Value);
            }
            else
            {
                mh = null;
            }
            return mh;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var mh = GetMH();
            if (mh == null)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var conn = new SqlConnection(_connectionString);
            var command = conn.CreateCommand();

            command.CommandText = "EXEC ThemMatHang @TenMatHang, @SoLuong, @DonGia, @MaLoai";

            command.Parameters.AddWithValue("@TenMatHang", mh.TenMH);
            command.Parameters.AddWithValue("@MaLoai", mh.MaLoai);
            command.Parameters.AddWithValue("@SoLuong", mh.SoLuong);
            command.Parameters.AddWithValue("@DonGia", mh.DonGia);

            conn.Open();
            var num = command.ExecuteNonQuery();

            if(num > 0)
            {
                MessageBox.Show("Thêm mặt hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetDSMatHang();
                LoadListView(_dsMatHang);
            }
            conn.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            var mh = GetMH();
            if (mh == null)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var conn = new SqlConnection(_connectionString);
            var command = conn.CreateCommand();

            command.CommandText = "EXEC CapNhatMatHang @MaMatHang, @TenMatHang, @SoLuong, @DonGia, @MaLoai";

            command.Parameters.AddWithValue("@MaMatHang", mh.MaMH);
            command.Parameters.AddWithValue("@TenMatHang", mh.TenMH);
            command.Parameters.AddWithValue("@MaLoai", mh.MaLoai);
            command.Parameters.AddWithValue("@SoLuong", mh.SoLuong);
            command.Parameters.AddWithValue("@DonGia", mh.DonGia);

            conn.Open();
            var num = command.ExecuteNonQuery();

            if(num > 0)
            {
                MessageBox.Show("Cập nhật mặt hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetDSMatHang();
                LoadListView(_dsMatHang);
            }
            conn.Close();
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            var form = new ThemLoai();
            form.ShowDialog();
            GetDSLoai();
        }
    }
}
