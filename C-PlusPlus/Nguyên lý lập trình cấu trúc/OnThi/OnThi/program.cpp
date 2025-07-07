#include<iostream>
#include<conio.h>
#include<fstream>
#include<iomanip>
#include<cstring>
using namespace std;
#include"thuvien.h"
#include"menu.h";
void ChayChuongTrinh()
{
	int menu, soMenu = 5;
	int n = 0;
	NhanVien a[MAX];
	do
	{
		menu = ChonMenu(soMenu);
		XuLyMenu(menu, a, n);
	} while (menu > 0);
}
int main()
{
	ChayChuongTrinh();
	return 1;
}

