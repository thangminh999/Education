#include<iostream>
#include<conio.h>
#include<time.h>
#include<stdlib.h>
using namespace std;
#include"2011438_thuvien.h"
#include"2011438_menu.h"
void ChayChuongTrinh()
{
	int menu,
		soMenu = 5,
		n = 0;
	MaTranVuong a;
	do
	{
		menu = ChonMenu(soMenu);
		XuLyMenu(menu, a, n);
	} while (menu >= 0);
	_getch();
}
int main()
{
	ChayChuongTrinh();
	return 1;
}