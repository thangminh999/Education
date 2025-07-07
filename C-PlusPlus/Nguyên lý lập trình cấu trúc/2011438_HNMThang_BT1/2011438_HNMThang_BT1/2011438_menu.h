void XuatMenu(int n) {
	cout << "		*************Chon chuc nang**************\n"
		<< "\n0.		Thoat chuong trinh\n"
		<< "\n1.		Xuat ra man hinh cac so nguyen to tu 2 toi " << n << '\n'
		<< "\n2.		Dem so luong chu so cua " << n << '\n'
		<< "\n3.		Xac dinh so dau trong " << n << '\n'
		<< "\n4.		Tinh tich cac so trong " << n << '\n'
		<< "\n		****************************************\n";
}

void XuLyMenu(unsigned int menu, int n) {
	switch (menu)
	{
	case 1:
		system("cls");
		cout << "\n1.Xuat ra man hinh cac so nguyen to tu 2 toi " << n << '\n';
		XuatND(n);
		_getch();
		system("cls");
		break;
	case 2:
		system("cls");
		cout << "\n2.		Dem so luong chu so cua " << n << '\n';
		DemSoLuong(n);
		_getch();
		system("cls");
		break;
	case 3:
		system("cls");
		cout << "\n3.		Xac dinh so dau trong " << n << '\n';
		SoDau(n);
		_getch();
		system("cls");
		break;
	case 4:
		system("cls");
		cout << "\n4.		Tinh tong cac so trong " << n << '\n';
		Tong(n);
		_getch();
		system("cls");
		break;
	}
}
