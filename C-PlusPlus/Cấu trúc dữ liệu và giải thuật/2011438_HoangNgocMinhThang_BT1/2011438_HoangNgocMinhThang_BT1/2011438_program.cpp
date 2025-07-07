#include <iostream>
#include <fstream> 
#include<iomanip>
#include<string.h>

using namespace std;
#include"2011438_thuvien.h"
#include"2011438_menu.h"

void ChayChuongTrinh()
{
	HocVien a[MAX];
	int soMenu = 5,
		menu,
		n = 0;
	do
	{
		system("CLS");
		menu = ChonMenu(soMenu);
		XuLyMenu(menu, a, n);
		system("PAUSE");
	} while (menu > 0);
}

int main()
{
	ChayChuongTrinh();
	return 1;
}