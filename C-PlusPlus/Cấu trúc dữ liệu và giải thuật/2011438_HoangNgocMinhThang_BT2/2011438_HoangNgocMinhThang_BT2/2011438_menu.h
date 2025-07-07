#pragma once
void XuatMenu();
int ChonMenu(int soMenu);
void XuLyMenu(int menu, hocvien a[MAX], int &n);

void XuatMenu()
{
	cout << "\n================ He thong chuc nang ===============";
	cout << "\n0. Thoat khoi chuong trinh";
	cout << "\n1. Tao danh sach hoc vien";
	cout << "\n2. Xem danh sach hoc vien";
	cout << "\n3. Sap danh sach hoc vien tang dan theo ma hoc vien(Chon truc tiep).";
	cout << "\n4. Sap danh sach hoc vien tang dan theo ma hoc vien(Quicksort).";
	cout << "\n5. Sap xep hoc vien tang dan theo yeu cau.";

}

int ChonMenu(int soMenu)
{
	int stt;
	for (;;)
	{
		system("CLS");
		XuatMenu();
		cout << "\nNhap mot so ( 0 <= so <= " << soMenu << " ) de chon menu, stt = ";
		cin >> stt;
		if (0 <= stt && stt <= soMenu)
			break;
	}
	return stt;
}

void XuLyMenu(int menu, hocvien a[MAX], int &n)
{
	int kq;
	char filename[MAX];
	char maSV[8];
	char hoSV[10];
	char ten[10];
	char lop[6];
	double dtb;
	switch (menu)
	{
	case 0:
		system("CLS");
		cout << "\n0. Thoat khoi chuong trinh\n";
		cout << "\nCam on vi da su dung.";
		break;
	case 1:
		system("CLS");
		cout << "\n1. Tao danh sach sinh vien";
		do {

			//cout << "\nNhap ten tap tin, filename = ";
			//cin >> filename;
			kq = File_Array("HocVien.txt", a, n);
			if (kq == 0)
				cout << "\nLoi mo file!\n";
		} while (kq == 0);
		cout << "\nDanh sach vua nhap la :\n";
		Xuat_DSHV(a, n);
		cout << endl;		break;

	case 2:
		system("CLS");
		cout << "\n2. Xem danh sach hoc vien\n";
		cout << "\nDanh sach hien hanh:\n";
		Xuat_DSHV(a, n);
		cout << endl;
		break;

	case 3:
		system("CLS");
		Selection(a, n);
		cout << "\n Danh sach sau khi sap xep.";
		Xuat_DSHV(a, n);
		cout << endl;
		break;

	case 4:
		system("CLS");
		cout << "\n4. Quicksort.";
		cout << "\n Danh sach sau khi sap xep.";
		Xuat_DSHV(a, n);
		cout << endl;
		break;
	case 5:
		system("CLS");
		cout << "\n5. Tang dan theo ten hoc vien.";
		SapXepTheoYeuCau(a, n);
		cout << "\n Danh sach sau khi sap xep.";
		Xuat_DSHV(a, n);
		cout << endl;
		break;
	}
	_getch();
}