using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class frmBanHang : Form
    {
        private string connectionString = @"Data Source=DESKTOP-TM999;Initial Catalog=QLBanHang;Integrated Security=True";

        public frmBanHang()
        {
            InitializeComponent();
            dgvMH.AutoGenerateColumns = false;
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            HienThiMatHang();
            HienThiLoaiMatHang();
        }
        private void HienThiMatHang()
        {
            var conn = new SqlConnection(connectionString);
            var command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM MATHANG";

            var adapter = new SqlDataAdapter(command);
            var table = new DataTable("MATHANG");

            conn.Open();
            adapter.Fill(table);
            conn.Close();

            dgvMH.DataSource = table;
        }
        private void HienThiLoaiMatHang()
        {
            var conn = new SqlConnection(connectionString);
            var command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM LOAIMATHANG";

            var adapter = new SqlDataAdapter(command);
            var table = new DataTable("LOAIMATHANG");

            conn.Open();
            adapter.Fill(table);
            conn.Close();

            cbbLoaiMH.DisplayMember = "TenLoai";
            cbbLoaiMH.ValueMember = "MaLoai";
            cbbLoaiMH.DataSource = table;
        }
        /*private void HienThiMatHang()
        {
            var conn = new SqlConnection(connectionString);
            var command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM MATHANG";

            var adapter = new SqlDataAdapter(command);
            var table = new DataTable("MATHANG");

            conn.Open();

            adapter.Fill(table);

            conn.Close();

            dgvMH.DataSource = table;
        }

        private void HienThiLoaiMatHang()
        {
            var conn = new SqlConnection(connectionString);
            var command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM LOAIMATHANG";

            var adapter = new SqlDataAdapter(command);
            var table = new DataTable("LOAIMATHANG");

            conn.Open();
            adapter.Fill(table);
            conn.Close();

            cbbLoaiMH.DisplayMember = "TENLOAI";
            cbbLoaiMH.ValueMember = "MALOAI";
            cbbLoaiMH.DataSource = table;
        
        }*/

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}
