#define MAX 100
struct NhanVien
{
	char maNV[8];
	char hoTen[21];
	short int ngaySinh;
	short int thangSinh;
	short int namSinh;
	char queQuan[15];
	long double luong;
};
int DocFile(char *filename, NhanVien a[MAX], int &n)
{
	ifstream in(filename);
	if (!in)
		return 0;
	n = 0;
	while (!in.eof())
	{
		in >> a[n].maNV;
		in >> a[n].hoTen;
		in >> a[n].ngaySinh;
		in >> a[n].thangSinh;
		in >> a[n].namSinh;
		in >> a[n].queQuan;
		in >> a[n].luong;
		n++;
	}
	in.close();
	return 1;
}
void XuatDuongKe()
{
	cout << setfill('=');
	cout << setw(100) << "=";
	cout << setfill(' ');
	cout << endl;
}
void XuatTieuDe()
{
	cout << setw(15) << left << "MaSoNV";
	cout << setw(25) << left << "Ho_Ten";
	cout << setw(10) << left << "NgaySinh";
	cout << setw(12) << left << "ThangSinh";
	cout << setw(10) << left << "NamSinh";
	cout << setw(15) << left << "Que_Quan";
	cout << setw(10) << left << "Luong";
	cout << endl;
}
void Xuat1NV(NhanVien &p)
{
	cout << setw(15) << left << p.maNV;
	cout << setw(25) << left << p.hoTen;
	cout << setw(10) << left << p.ngaySinh;
	cout << setw(12) << left << p.thangSinh;
	cout << setw(10) << left << p.namSinh;
	cout << setw(15) << left << p.queQuan;
	cout <<setiosflags(ios::fixed)<<setprecision(2)<< setw(10) << left << p.luong;
	cout << endl;
}
void XuatDanhSachNV(NhanVien a[MAX], int &n)
{
	XuatDuongKe();
	XuatTieuDe();
	XuatDuongKe();
	for (int i = 0; i < n; i++)
		Xuat1NV(a[i]);
	XuatDuongKe();
}
void NhanVienNamSinh(NhanVien a[MAX], int n, short int nam)
{
	int kq = 0;
	for (int i = 0; i < n; i++)
	{
		if (a[i].namSinh == nam)
			kq++;
	}
	if (kq == 0)
		cout << endl << "Khong co nhan vien nao sinh nam " << nam << ".";
	else
	{
		cout << endl << "Co " << kq << " nhan vien sinh nam " << nam << ".";
		cout << endl << "Danh sach nhan vien sinh nam " << nam << ":" << endl;
		XuatDuongKe();
		XuatTieuDe();
		XuatDuongKe();
		for (int i = 0; i < n; i++)
		{
			if (a[i].namSinh == nam)
				Xuat1NV(a[i]);
		}
		XuatDuongKe();
	}
}
void NhanVienCoLuongThapNhat(NhanVien a[MAX], int n)
{
	long double min = a[0].luong;
	for (int i = 0; i < n; i++)
	{
		if (a[i].luong < min)
			a[i].luong = min;
	}
	cout << endl << "So luong thap nhat ma nhan vien co duoc la: " << min;
	cout << endl << "Danh sach nhan vien co luong thap nhat:" << endl;
	XuatDuongKe();
	XuatTieuDe();
	XuatDuongKe();
	for (int i = 0; i < n; i++)
	{
		if (a[i].luong == min)
			Xuat1NV(a[i]);
	}
	XuatDuongKe();
}
void XoaNhanVienQueQuan(NhanVien a[MAX], int&n, char *quequan)
{
	int i = 0, j;
	for(;;)
	{
		for (i = 0; i < n; i++)
		{
			if (strcmp(a[i].queQuan, quequan) == 0)
				break;
		}
		if (i == n)
			break;
		for (j = i + 1; j < n; j++)
			a[j - 1] = a[j];
		n--;
	}
	cout << endl << "Danh sach nhan vien sau khi xoa:" << endl;
	XuatDanhSachNV(a, n);
}
