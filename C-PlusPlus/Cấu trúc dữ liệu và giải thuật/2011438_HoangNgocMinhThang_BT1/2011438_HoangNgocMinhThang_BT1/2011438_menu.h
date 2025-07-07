void XuatMenu();
int ChonMenu(int soMenu);
void XuLyMenu(int menu, HocVien a[MAX], int &n);


void XuatMenu()
{
	cout << "\n======================= He Thong Chuc Nang =====================";
	cout << "\n0. Thoat khoi chuong trinh";
	cout << "\n1. Tao DS Hoc Vien ( chuyen du lieu tu tap tin cho truoc vao mang cau truc )";
	cout << "\n2. Xem DS Hoc vien";
	cout << "\n3. Tim Kiem Theo Lop Va So Tin Chi";
	cout << "\n4. Tim Kiem Theo Ten";
	cout << "\n5. Tim Kiem Theo Nam Sinh Va Diem Trung Binh";
	cout << "\n===============================================================";
}

int ChonMenu(int soMenu)
{
	int stt;
	for (;;)
	{
		system("CLS");
		XuatMenu();
		cout << "\nNhap mot so (0 <= so <= " << soMenu << " ) de chon menu, stt = ";
		cin >> stt;
		if (0 <= stt && stt <= soMenu)
			break;
	}
	return stt;
}

void XuLyMenu(int menu, HocVien a[MAX], int &n)
{
	int kq;
	char filename[MAX];
	char ten[20];
	switch (menu)
	{
	case 0:
		system("CLS");
		cout << "\n0. Thoat khoi chuong trinh\n";
		break;
	case 1:
		system("CLS");
		cout << "\n1. Tao danh sach hoc vien";
		do
		{
			cout << "\nNhap ten tap tin, filename = ";
			cin >> filename;
			kq = TapTin_MangCT(filename, a, n);
		} while (!kq);
		cout << "\n Nhap File Thanh Cong. Successful !!!\n";
		//Xuat_DSHV(a, n);
		cout << endl;
		break;
	case 2:
		system("CLS");
		cout << "\n2. Xem danh sach hoc vien\n";
		cout << "\nDuoi Day La Bang Danh Sach Hoc Vien:\n";
		Xuat_DSHV(a, n);
		cout << endl;
		break;
	case 3:
		int sotinchichotruoc;
		char lopchotruoc[10];
		cout << " moi ban nhap lop cho truoc :";
		cin >> lopchotruoc;
		cout << " moi ban nhap so tin chi ";
		cin >> sotinchichotruoc;
		Tim_TheoLopVaSoTinChi(lopchotruoc, sotinchichotruoc, a, n);
		break;
	case 4:
		cout << "\nTim kiem theo ten cho truoc :\n";
		char ten[10];
		cin >> ten;
		TimHV_TheoTen(ten, a, n);
		break;
	case 5:
		cout << "\ntim kiem theo nam sinh va diem trung binh ";
		int namsinhChoTruoc;
		double diemTrungBinhChoTruoc;
		cout << "moi ban nhap nam sinh :";
		cin >> namsinhChoTruoc;
		cout << "moi ban nhap diem trung binh :";
		cin >> diemTrungBinhChoTruoc;
		Tim_TheoNamSinhVaDiemTrungBinh(diemTrungBinhChoTruoc, namsinhChoTruoc, a, n);
		break;
	}
}