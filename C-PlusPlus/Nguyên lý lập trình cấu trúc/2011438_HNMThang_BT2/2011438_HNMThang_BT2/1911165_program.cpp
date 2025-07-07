#include <iostream>
#include <conio.h>
#include <time.h>
#include <stdlib.h>
#include <iomanip>

using namespace std;

#include "1911165_thuvien.h"
#include "1911165_menu.h"

void ChayChuongTrinh();

int main()
{
	ChayChuongTrinh();
	return 0;
}

void ChayChuongTrinh()
{
	int soMenu = 6, menu, n;
	DaySo a;

	do
	{
		menu = ChonMenu(soMenu);
		XuLyMenu(menu, a, n);
	} while (menu > 0);

	_getch();
}