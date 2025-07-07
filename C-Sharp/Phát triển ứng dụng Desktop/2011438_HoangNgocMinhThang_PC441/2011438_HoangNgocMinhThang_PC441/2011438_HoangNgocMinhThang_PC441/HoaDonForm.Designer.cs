namespace _2011438_HoangNgocMinhThang_PC441
{
    partial class HoaDonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hoaDonBanHang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.cbbKH = new System.Windows.Forms.ComboBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.chiTietBanHang = new System.Windows.Forms.Label();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.chTenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.phaiTra = new System.Windows.Forms.Label();
            this.giamGia = new System.Windows.Forms.Label();
            this.nudGiamGia = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhaiTra = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuyDon = new System.Windows.Forms.Button();
            this.btnChonHD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiamGia)).BeginInit();
            this.SuspendLayout();
            // 
            // hoaDonBanHang
            // 
            this.hoaDonBanHang.AutoSize = true;
            this.hoaDonBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoaDonBanHang.Location = new System.Drawing.Point(126, 9);
            this.hoaDonBanHang.Name = "hoaDonBanHang";
            this.hoaDonBanHang.Size = new System.Drawing.Size(310, 33);
            this.hoaDonBanHang.TabIndex = 0;
            this.hoaDonBanHang.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày xuất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khách hàng";
            // 
            // dtpNgayXuat
            // 
            this.dtpNgayXuat.Checked = false;
            this.dtpNgayXuat.CustomFormat = "dd/mm/yyyy";
            this.dtpNgayXuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayXuat.Location = new System.Drawing.Point(84, 74);
            this.dtpNgayXuat.Name = "dtpNgayXuat";
            this.dtpNgayXuat.Size = new System.Drawing.Size(166, 20);
            this.dtpNgayXuat.TabIndex = 3;
            // 
            // cbbKH
            // 
            this.cbbKH.FormattingEnabled = true;
            this.cbbKH.Location = new System.Drawing.Point(358, 73);
            this.cbbKH.Name = "cbbKH";
            this.cbbKH.Size = new System.Drawing.Size(182, 21);
            this.cbbKH.TabIndex = 4;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(546, 73);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(35, 23);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "+";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // chiTietBanHang
            // 
            this.chiTietBanHang.AutoSize = true;
            this.chiTietBanHang.Location = new System.Drawing.Point(23, 130);
            this.chiTietBanHang.Name = "chiTietBanHang";
            this.chiTietBanHang.Size = new System.Drawing.Size(87, 13);
            this.chiTietBanHang.TabIndex = 6;
            this.chiTietBanHang.Text = "Chi tiết bán hàng";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chTenHang,
            this.chSoLuong,
            this.chDonGia,
            this.chThanhTien});
            this.dgvHoaDon.Location = new System.Drawing.Point(26, 156);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(555, 169);
            this.dgvHoaDon.TabIndex = 7;
            // 
            // chTenHang
            // 
            this.chTenHang.HeaderText = "Tên hàng";
            this.chTenHang.Name = "chTenHang";
            this.chTenHang.Width = 150;
            // 
            // chSoLuong
            // 
            this.chSoLuong.HeaderText = "Số Lượng";
            this.chSoLuong.Name = "chSoLuong";
            this.chSoLuong.Width = 130;
            // 
            // chDonGia
            // 
            this.chDonGia.HeaderText = "Đơn giá";
            this.chDonGia.Name = "chDonGia";
            this.chDonGia.Width = 150;
            // 
            // chThanhTien
            // 
            this.chThanhTien.HeaderText = "Thành tiền";
            this.chThanhTien.Name = "chThanhTien";
            this.chThanhTien.Width = 180;
            // 
            // tongTien
            // 
            this.tongTien.AutoSize = true;
            this.tongTien.Location = new System.Drawing.Point(26, 338);
            this.tongTien.Name = "tongTien";
            this.tongTien.Size = new System.Drawing.Size(52, 13);
            this.tongTien.TabIndex = 8;
            this.tongTien.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(84, 338);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(127, 20);
            this.txtTongTien.TabIndex = 9;
            // 
            // phaiTra
            // 
            this.phaiTra.AutoSize = true;
            this.phaiTra.Location = new System.Drawing.Point(408, 338);
            this.phaiTra.Name = "phaiTra";
            this.phaiTra.Size = new System.Drawing.Size(43, 13);
            this.phaiTra.TabIndex = 10;
            this.phaiTra.Text = "Phải trả";
            // 
            // giamGia
            // 
            this.giamGia.AutoSize = true;
            this.giamGia.Location = new System.Drawing.Point(239, 338);
            this.giamGia.Name = "giamGia";
            this.giamGia.Size = new System.Drawing.Size(56, 13);
            this.giamGia.TabIndex = 11;
            this.giamGia.Text = "%Giảm giá";
            // 
            // nudGiamGia
            // 
            this.nudGiamGia.Location = new System.Drawing.Point(301, 338);
            this.nudGiamGia.Name = "nudGiamGia";
            this.nudGiamGia.Size = new System.Drawing.Size(51, 20);
            this.nudGiamGia.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(358, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "%";
            // 
            // txtPhaiTra
            // 
            this.txtPhaiTra.Location = new System.Drawing.Point(458, 338);
            this.txtPhaiTra.Name = "txtPhaiTra";
            this.txtPhaiTra.ReadOnly = true;
            this.txtPhaiTra.Size = new System.Drawing.Size(123, 20);
            this.txtPhaiTra.TabIndex = 15;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(232, 382);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(93, 23);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuyDon
            // 
            this.btnHuyDon.Location = new System.Drawing.Point(361, 382);
            this.btnHuyDon.Name = "btnHuyDon";
            this.btnHuyDon.Size = new System.Drawing.Size(93, 23);
            this.btnHuyDon.TabIndex = 17;
            this.btnHuyDon.Text = "Hủy hóa đơn";
            this.btnHuyDon.UseVisualStyleBackColor = true;
            // 
            // btnChonHD
            // 
            this.btnChonHD.Location = new System.Drawing.Point(484, 382);
            this.btnChonHD.Name = "btnChonHD";
            this.btnChonHD.Size = new System.Drawing.Size(97, 23);
            this.btnChonHD.TabIndex = 18;
            this.btnChonHD.Text = "Chọn HĐ đã bán";
            this.btnChonHD.UseVisualStyleBackColor = true;
            // 
            // HoaDonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 417);
            this.Controls.Add(this.btnChonHD);
            this.Controls.Add(this.btnHuyDon);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtPhaiTra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudGiamGia);
            this.Controls.Add(this.giamGia);
            this.Controls.Add(this.phaiTra);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.tongTien);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.chiTietBanHang);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.cbbKH);
            this.Controls.Add(this.dtpNgayXuat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hoaDonBanHang);
            this.Name = "HoaDonForm";
            this.Text = "HoaDonForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiamGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hoaDonBanHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgayXuat;
        private System.Windows.Forms.ComboBox cbbKH;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label chiTietBanHang;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Label tongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label phaiTra;
        private System.Windows.Forms.Label giamGia;
        private System.Windows.Forms.NumericUpDown nudGiamGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhaiTra;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuyDon;
        private System.Windows.Forms.Button btnChonHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn chTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn chSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn chDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn chThanhTien;
    }
}