
void XuatMenu();
int  ChonMenu(int soMenu);
void XuLyMenu(int menu, DaySo a, int &n);

void XuatMenu()
{
	cout << "\n0. Thoat chuong trinh";
	cout << "\n1. Nhap mang tu dong";
	cout << "\n2. Xuat mang";
	cout << "\n3. Tinh tong";
	cout << "\n4. Xuat ra so nho nhat trong mang";
	cout << "\n5. Vi tri xuat hien so nho nhat";
	cout << "\n6. Sap xep so 0 o cuoi mang - am giam - duong tang";
}

int ChonMenu(int soMenu)
{
	int stt;

	do
	{
		system("cls");
		XuatMenu();
		cout << "\nChon chuc nang >> ";
		cin >> stt;
	} while (stt < 0 || stt > soMenu);

	return stt;
}

void XuLyMenu(int menu, DaySo a, int &n)
{
	switch (menu)
	{
	case 0:
		cout << "\n0. Thoat chuong trinh";
		break;
	case 1:
		cout << "\n1. Nhap mang tu dong";
		NhapMangTuDong(a, n);
		cout << "\nMang vua nhap:\n";
		XuatMang(a, n);
		break;
	case 2:
		cout << "\n2. Xuat mang\n";
		XuatMang(a, n);
		break;
	case 3:
		cout << "\n3. Tinh Tong";
		cout << "\nCac so trong mang : ";
		XuatMang(a, n);
		cout << "\nTong cua cac so trong mang la : ";
		TinhTong(a, n);


		break;
	case 4:
		cout << "\n4. Xuat so nho nhat";
		cout << "\nCac so trong mang\n";
		XuatMang(a, n);
		cout << "\nSo nho nhat : ";
		soNhoNhat(a, n);
		break;
	case 5:
		cout << "\n5. Vi tri so nho nhat";
		cout << "\nCac so trong mang\n";
		XuatMang(a, n);
		cout << "\nSo nho nhat : ";
		VTsoNhoNhat(a, n);
		break;
	case 6:
		cout << "\n6. Sap xep so 0 cuoi mang - am giam - duong tang";
		cout << "\nMang a truoc khi sap xep\n";
		XuatMang(a, n);
		cout << "\nMang a sau khi sap xep\n";
		XuatMang(a, n);
		break;
	}

	_getch();
}
