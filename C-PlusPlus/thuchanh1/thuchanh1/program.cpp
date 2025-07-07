#include<iostream>
#include<conio.h>
#include<iomanip>

#define MAX		100
#define	KHOA	"Cong nghe thong tin"
#define PI		3.1415926
#define TAB		'\t'
/*const int MAX = 100;
const char KHOA[] = "Cong nghe thong tin";
const float PI = 3.1415926;
const char TAB = '\t';*/


using namespace std;

int main() 
{
	/*cout << setiosflags(ios::left)
		<< setw(10) << "MSSV"
		<< setw(25) << "Ho va ten"
		<< setw(10) << "Lop"
		<< setw(10) << "Diem TB"
		<< setw(10) << "Diem TL"
		<< endl;
	cout << setiosflags(ios::left)
		<< setw(10) << "2011438"
		<< setw(25) << "HOANG NGOC MINH THANG"
		<< setw(10) << "CTK44"
		<< setw(10) << "7.50"
		<< setw(10) << setprecision(2) << 5.75
		<< endl;*/

	cout << endl << "MAX = " << MAX;
	cout << endl << "KHOA: " << KHOA;
	cout << endl << "PI = " << PI;
	cout << endl << TAB << " TAB 1 o";

	_getch();
	return 1;
}