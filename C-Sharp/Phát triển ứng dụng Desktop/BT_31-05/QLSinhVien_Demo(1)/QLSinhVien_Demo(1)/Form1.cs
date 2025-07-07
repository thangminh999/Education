using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVien_Demo_1_
{
    public partial class frmSinhVien : Form
    {
        private const string DefaultSearchText = "Nhập tên sinh viên";
        private QLSinhVienContext context;
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            context = new QLSinhVienContext();
            SetSearchText();
            GetAllLop();
            btnTaiLai.PerformClick();
        }
        private void SetSearchText()
        {
            txtTimKiem.Text = DefaultSearchText;
            txtTimKiem.GotFocus += TxtSearchOnGotFocus;
            txtTimKiem.LostFocus += TxtSearchOnLostFocus;
        }
        private void TxtSearchOnLostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                txtTimKiem.Text = DefaultSearchText;
                btnTaiLai.PerformClick();
            }
        }
        private void TxtSearchOnGotFocus(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
        }
        private void GetAllLop()
        {
            var list = context.Lop.ToList();
            cbLop.DisplayMember = "TenLop";
            cbLop.ValueMember = "Id";
            cbLop.DataSource = list;
        }
        private void LoadListView(List<SinhVien> List)
        {
            lvSinhVien.Items.Clear();
            foreach (var sinhVien in List)
            {
                AddSVToLV(sinhVien);
            }
        }
        private void AddSVToLV(SinhVien sv)
        {
            string[] row = { sv.ID.ToString(), sv.HoTen, sv.MaLop.ToString() };
            var item = new ListViewItem(row);
            lvSinhVien.Items.Add(item);
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            var list = context.SinhVien.ToList();
            LoadListView(list);
        }
        private SinhVien GetSinhVien()
        {
            var sv = new SinhVien();
            if(!string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                sv.HoTen = txtHoTen.Text;
                sv.ID = string.IsNullOrWhiteSpace(txtID.Text) ? -1: int.Parse(txtID.Text);
                sv.MaLop = Convert.ToInt32(cbLop.SelectedValue);
            }
            return sv;
        }
        private void ThietLapThongTin(SinhVien sv)
        {
            txtHoTen.Text = sv.HoTen;
            txtID.Text = sv.ID.ToString();
            cbLop.SelectedValue = sv.MaLop;
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtHoTen.Text = "";
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        { //2011438
            var searchText = txtTimKiem.Text;
            var list = context.SinhVien.Where(sv => sv.HoTen.Contains(searchText))
                .ToList();
            LoadListView(list);
        }
    }
}
