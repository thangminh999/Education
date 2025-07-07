namespace _2011438_HoangNgocMinhThang_PC441
{
    partial class QLKHForm
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
            this.maKH = new System.Windows.Forms.Label();
            this.tenKH = new System.Windows.Forms.Label();
            this.soDT = new System.Windows.Forms.Label();
            this.diaChiGiaoHang = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.mtxtSoDT = new System.Windows.Forms.MaskedTextBox();
            this.btnMacDinh = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.gbTimKiem = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rdTheoSDT = new System.Windows.Forms.RadioButton();
            this.rdTheoTen = new System.Windows.Forms.RadioButton();
            this.danhSachKH = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.ListBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.lvKhachHang = new System.Windows.Forms.ListView();
            this.chMaKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTenKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSoDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // maKH
            // 
            this.maKH.AutoSize = true;
            this.maKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maKH.Location = new System.Drawing.Point(42, 27);
            this.maKH.Name = "maKH";
            this.maKH.Size = new System.Drawing.Size(92, 15);
            this.maKH.TabIndex = 0;
            this.maKH.Text = "Mã khách hàng";
            // 
            // tenKH
            // 
            this.tenKH.AutoSize = true;
            this.tenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenKH.Location = new System.Drawing.Point(42, 62);
            this.tenKH.Name = "tenKH";
            this.tenKH.Size = new System.Drawing.Size(95, 15);
            this.tenKH.TabIndex = 1;
            this.tenKH.Text = "Tên khách hàng";
            // 
            // soDT
            // 
            this.soDT.AutoSize = true;
            this.soDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soDT.Location = new System.Drawing.Point(42, 96);
            this.soDT.Name = "soDT";
            this.soDT.Size = new System.Drawing.Size(79, 15);
            this.soDT.TabIndex = 2;
            this.soDT.Text = "Số điện thoại";
            // 
            // diaChiGiaoHang
            // 
            this.diaChiGiaoHang.AutoSize = true;
            this.diaChiGiaoHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaChiGiaoHang.Location = new System.Drawing.Point(348, 20);
            this.diaChiGiaoHang.Name = "diaChiGiaoHang";
            this.diaChiGiaoHang.Size = new System.Drawing.Size(103, 15);
            this.diaChiGiaoHang.TabIndex = 3;
            this.diaChiGiaoHang.Text = "Địa chỉ giao hàng";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(141, 20);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(179, 20);
            this.txtMaKH.TabIndex = 0;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(141, 55);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(179, 20);
            this.txtTenKH.TabIndex = 1;
            // 
            // mtxtSoDT
            // 
            this.mtxtSoDT.Location = new System.Drawing.Point(141, 93);
            this.mtxtSoDT.Mask = "0000000000";
            this.mtxtSoDT.Name = "mtxtSoDT";
            this.mtxtSoDT.Size = new System.Drawing.Size(179, 20);
            this.mtxtSoDT.TabIndex = 2;
            // 
            // btnMacDinh
            // 
            this.btnMacDinh.Location = new System.Drawing.Point(200, 137);
            this.btnMacDinh.Name = "btnMacDinh";
            this.btnMacDinh.Size = new System.Drawing.Size(75, 23);
            this.btnMacDinh.TabIndex = 4;
            this.btnMacDinh.Text = "Mặc định";
            this.btnMacDinh.UseVisualStyleBackColor = true;
            this.btnMacDinh.Click += new System.EventHandler(this.btnMacDinh_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(325, 137);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // gbTimKiem
            // 
            this.gbTimKiem.Controls.Add(this.txtTimKiem);
            this.gbTimKiem.Controls.Add(this.rdTheoSDT);
            this.gbTimKiem.Controls.Add(this.rdTheoTen);
            this.gbTimKiem.Location = new System.Drawing.Point(200, 177);
            this.gbTimKiem.Name = "gbTimKiem";
            this.gbTimKiem.Size = new System.Drawing.Size(323, 52);
            this.gbTimKiem.TabIndex = 10;
            this.gbTimKiem.TabStop = false;
            this.gbTimKiem.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(161, 19);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(156, 20);
            this.txtTimKiem.TabIndex = 2;
            // 
            // rdTheoSDT
            // 
            this.rdTheoSDT.AutoSize = true;
            this.rdTheoSDT.Location = new System.Drawing.Point(80, 19);
            this.rdTheoSDT.Name = "rdTheoSDT";
            this.rdTheoSDT.Size = new System.Drawing.Size(75, 17);
            this.rdTheoSDT.TabIndex = 1;
            this.rdTheoSDT.TabStop = true;
            this.rdTheoSDT.Text = "Theo SDT";
            this.rdTheoSDT.UseVisualStyleBackColor = true;
            // 
            // rdTheoTen
            // 
            this.rdTheoTen.AutoSize = true;
            this.rdTheoTen.Location = new System.Drawing.Point(6, 19);
            this.rdTheoTen.Name = "rdTheoTen";
            this.rdTheoTen.Size = new System.Drawing.Size(68, 17);
            this.rdTheoTen.TabIndex = 0;
            this.rdTheoTen.TabStop = true;
            this.rdTheoTen.Text = "Theo tên";
            this.rdTheoTen.UseVisualStyleBackColor = true;
            // 
            // danhSachKH
            // 
            this.danhSachKH.AutoSize = true;
            this.danhSachKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhSachKH.Location = new System.Drawing.Point(12, 214);
            this.danhSachKH.Name = "danhSachKH";
            this.danhSachKH.Size = new System.Drawing.Size(133, 15);
            this.danhSachKH.TabIndex = 11;
            this.danhSachKH.Text = "Danh sách khách hàng";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.FormattingEnabled = true;
            this.lbDiaChi.IntegralHeight = false;
            this.lbDiaChi.Items.AddRange(new object[] {
            "."});
            this.lbDiaChi.Location = new System.Drawing.Point(351, 44);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(172, 69);
            this.lbDiaChi.TabIndex = 3;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(448, 347);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 7;
            this.btnExcel.Text = "Xuất Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // lvKhachHang
            // 
            this.lvKhachHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chMaKH,
            this.chTenKH,
            this.chSoDT,
            this.chDiaChi});
            this.lvKhachHang.GridLines = true;
            this.lvKhachHang.Location = new System.Drawing.Point(16, 232);
            this.lvKhachHang.Name = "lvKhachHang";
            this.lvKhachHang.Size = new System.Drawing.Size(507, 109);
            this.lvKhachHang.TabIndex = 6;
            this.lvKhachHang.UseCompatibleStateImageBehavior = false;
            this.lvKhachHang.View = System.Windows.Forms.View.Details;
            this.lvKhachHang.Click += new System.EventHandler(this.lvKhachHang_Click);
            // 
            // chMaKH
            // 
            this.chMaKH.Text = "Mã KH";
            this.chMaKH.Width = 80;
            // 
            // chTenKH
            // 
            this.chTenKH.Text = "Tên khách hàng";
            this.chTenKH.Width = 150;
            // 
            // chSoDT
            // 
            this.chSoDT.Text = "Số điện thoại";
            this.chSoDT.Width = 120;
            // 
            // chDiaChi
            // 
            this.chDiaChi.Text = "Địa chỉ giao hàng";
            this.chDiaChi.Width = 150;
            // 
            // QLKHForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 380);
            this.Controls.Add(this.lvKhachHang);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.danhSachKH);
            this.Controls.Add(this.gbTimKiem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnMacDinh);
            this.Controls.Add(this.mtxtSoDT);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.diaChiGiaoHang);
            this.Controls.Add(this.soDT);
            this.Controls.Add(this.tenKH);
            this.Controls.Add(this.maKH);
            this.Name = "QLKHForm";
            this.Text = "Quản lý khách hàng";
            this.gbTimKiem.ResumeLayout(false);
            this.gbTimKiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label maKH;
        private System.Windows.Forms.Label tenKH;
        private System.Windows.Forms.Label soDT;
        private System.Windows.Forms.Label diaChiGiaoHang;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.MaskedTextBox mtxtSoDT;
        private System.Windows.Forms.Button btnMacDinh;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox gbTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RadioButton rdTheoSDT;
        private System.Windows.Forms.RadioButton rdTheoTen;
        private System.Windows.Forms.Label danhSachKH;
        private System.Windows.Forms.ListBox lbDiaChi;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.ListView lvKhachHang;
        private System.Windows.Forms.ColumnHeader chMaKH;
        private System.Windows.Forms.ColumnHeader chTenKH;
        private System.Windows.Forms.ColumnHeader chSoDT;
        private System.Windows.Forms.ColumnHeader chDiaChi;
    }
}

