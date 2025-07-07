void XuatMenu()
{
	cout << endl << "======================= HE THONG CHUC NANG =======================";
	cout << endl << "1. Nhap danh sach nhan vien";
	cout << endl << "2. Xem danh sach nhan vien";
	cout << endl << "3. Danh sach nhan vien co nam sinh cho truoc";
	cout << endl << "4. Danh sach nhan vien co luong thap nhat";
	cout << endl << "5. Xoa nhan vien co que quan cho truoc";
	cout << endl << "0. Thoat chuong trinh";
	cout << endl << "==================================================================";
}
int ChonMenu(int soMenu)
{
	int stt;
	for(;;)
	{
		system("CLS");
		XuatMenu();
		cout << endl << "Nhap 1 so [0.." << soMenu << "] de chon chuc nang tuong ung: ";
		cin >> stt;
		if (0 <= stt&&stt <= soMenu)
			break;
	}
	return stt;
}
void XuLyMenu(int menu, NhanVien a[MAX], int &n)
{
	char filename[80];
	char quequan[20];
	int kq;
	short int nam;
	system("CLS");
	switch (menu)
	{
	case 0:
		cout << endl << "Thoat chuong trinh";
		cout << endl << "Nhan 1 phim bat ki de tiep tuc";
		break;
	case 1:
		cout << endl << "Nhap tu dong danh sach nhan vien";
		do
		{
			cout << endl << "Xin hay nhap ten file: ";
			cin >> filename;
			kq = DocFile(filename, a, n);
			if (kq == 0)
			{
				cout << endl << "Loi mo file. Xin hay nhap lai";
				system("PAUSE");
			}
		} while (kq == 0);
		cout << endl << "Nhan 1 phim bat ki de tiep tuc";
		break;
	case 2:
		cout << endl << "Danh sanh nhan vien: " << endl;
		XuatDanhSachNV(a, n);
		cout << endl << "Nhan 1 phim bat ki de tiep tuc";
		break;
	case 3:
		cout << endl << "Xuat danh sach nhan vien co nam sinh cho truoc.";
		cout << endl << "Xin hay nhap nam sinh: ";
		cin >> nam;
		NhanVienNamSinh(a, n, nam);
		cout << endl << "Nhan 1 phim bat ki de tiep tuc";
		break;
	case 4:
		NhanVienCoLuongThapNhat(a, n);
		cout << endl << "Nhan 1 phim bat ki de tiep tuc";
		break;
	case 5:
		cout << endl << "Xoa nhan vien co que quan cho truoc";
		cout << endl << "Xin hay nhap que quan: ";
		cin >> quequan;
		XoaNhanVienQueQuan(a, n, quequan);
		cout << endl << "Nhan 1 phim bat ki de tiep tuc";
		break;
	}
	_getch();
}