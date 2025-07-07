#include <iostream>
#include <conio.h>
#include <math.h>

using namespace std;

#include "2011438_thuvien.h"
#include "2011438_menu.h"

void ChayChuongTrinh();

int main() {
	ChayChuongTrinh();
}

void ChayChuongTrinh() {
	int n;
	unsigned int menu;
	cout << "\nNhap vao 1 so tu nhien : ";
	cin >> n;
	do {
		XuatMenu(n);
		cout << "Chon chuc nang : ";
		cin >> menu;
		XuLyMenu(menu, n);
	} while (menu > 0);
	system("cls");
	cout << "\n	Cam on ban da su dung chuong trinh  ";
	_getch();
	system("cls");
}