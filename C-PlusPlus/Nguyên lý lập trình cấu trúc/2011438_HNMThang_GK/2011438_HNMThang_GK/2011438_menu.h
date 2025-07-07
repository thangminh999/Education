void XuatMenu();
int ChonMenu(int soMenu);
void XuLyMenu(int menu, MaTranVuong a, int &n);
void XuatMenu()
{
	cout << "\n ============== MOI BAN CHON ============";
	cout << "\n0. Thoat khoi chuong trinh";
	cout << "\n1. Nhap tu dong ma tran vuong a cap n cac s nguyen trong khoang [-4;4]";
	cout << "\n2. Xem ma tran";
	cout << "\n3. Tinh tong cac phan tu cot j";
	cout << "\n4. Tinh tich cac phan tu hang i";
	cout << "\n5. Xuat ra ma hinh cac phan tu aij thoa man";
}
int ChonMenu(int soMenu)
{
	int stt;
	for (;;)
	{
		system("CLS");
		XuatMenu();
		cout << "\nNhap 1 so trong khoang [0.." << soMenu << "] de chon menu. STT= ";
		cin >> stt;
		if (stt >= 0 && stt <= soMenu)
			break;
	}
	return stt;
}
void XuLyMenu(int menu, MaTranVuong a, int &n)
{
	system("CLS");
	int kq, j, i;
	switch (menu)
	{
	case 0:
		cout << "\n0.Thoat khoi chuog trinh";
		break;
	case 1:
		cout << "\n1. Nhap tu dong ma tran vuong a cap n cac s nguyen trong khoang [-4;4]";
		cout << " \n Nhap cap ma tran vuong a: n= \n";
		cin >> n;
		NhapMaTran(a, n);
		cout << "\n MA tran vuong cap n: \n";
		XuatMaTran(a, n);
		break;
	case 2:
		cout << "\n2. Xem ma tran";
		cout << "\n Ma tran vuong hien hanh:\n";
		XuatMaTran(a, n);
		break;
	case 3:
		cout << "\n3. Tinh tong cac phan tu cot j";
		do
		{
			cout << " Chon cot j(0<=j<=" << n - 1 << "):j=";
			cin >> j;
		} while (j<0 || j>n - 1);
		kq = TinhTong_Cotj(a, n, j);
		cout << "\n Ma tran hien hanh:\n";
		XuatMaTran(a, n);
		cout << "\n Tong(cot" << j << ")=" << kq;

		break;
	case 4:
		cout << "\n4. Tinh tich cac phan tu hang i";
		do
		{
			cout << " Chon hang i(0<=i<=" << n - 1 << "):i=";
			cin >> i;
		} while (i<0 || i>n - 1);
		kq = TinhTich_Hangi(a, n, i);
		cout << "\n Ma tran hien hanh:\n";
		XuatMaTran(a, n);
		cout << "\n Tich(hang" << i << ")=" << kq;
		break;
	case 5:
		cout << "\n5. Xuat ra ma hinh cac phan tu aij thoa man ";
		break;

	}
	_getch();
}