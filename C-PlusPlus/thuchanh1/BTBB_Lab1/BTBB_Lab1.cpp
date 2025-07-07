#include<iostream>
#include<iomanip>
#include<conio.h>
#include<math.h>

#define	MAX	3600
#define SIXTY 60
const char TCHAR[] = "*****";
const char SCHAR[] = "* * * * *";

using namespace std;

int main()
{
	//BAI1
	/*int k; long x; float a; double h; char c[20];
	cout << "Nhap k: ";
	cin >> k;
	cout << "Nhap x: ";
	cin >> x;
	cout << "Nhap a_fl: ";
	cin >> a;
	cout << "Nhap h: ";
	cin >> h;
	cout << "Nhap c: ";
	cin >> c;

	cout << "Ban vua nhap K = " << k<< endl;
	cout << "Ban vua nhap x = " << x<<endl;
	cout << "Ban vua nhap a = " << a<<endl;
	cout << "Ban vua nhap h = " << h<<endl;
	cout << "Ban vua nhap c = " << c;*/

	//BAI2
	/*cout << SCHAR
		<< "\t\t" << SCHAR << "\t\t" << SCHAR << endl;
	cout << " " << SCHAR
		<< "\t\t" << "*   *" << "\t\t" << " *     *" << endl;
	cout << SCHAR
		<< "\t\t" << "*   *" << "\t\t" << "  *   *" << endl;
	cout << " " << SCHAR
		<< "\t\t" << "*   *" << "\t\t" << "   * *" << endl;
	cout << SCHAR
		<< "\t\t" << SCHAR << "\t\t" << "    *" << endl;
	//
	cout << "   (a)" << "\t\t (b)";*/
	
	//BAI3
	/*int x, y;
	cout << "Nhap x: ";
	cin >> x;
	cout << "Nhap y: ";
	cin >> y;
	//
	cout << "=== KET QUA ===" << "\n"
		<< setw(10) << "x + y= " << x + y << endl
		<< setw(10) << "x - y= " << x - y << endl
		<< setw(10) << "x * y= " << x * y << endl
		<< setw(10) << "x % y= " << x % y;*/

	//BAI4
	/*int a, b, c;
	float chuVi, dienTich, p;
	//
	cout << "Nhap a: ";
	cin >> a;
	cout << "Nhap b: ";
	cin >> b;
	cout << "Nhap c: ";
	cin >> c;
	cout << endl;
	cout << "=== KET QUA ===" << endl;
	//
	chuVi = a + b + c, 
		p = chuVi / 2.0, 
			dienTich = sqrt(p*(p-a)*(p-b)*(p-c));
	cout << "Chu vi hinh tam giac la: " << chuVi << endl;
	cout << "Dien tich hinh tam giac la: " << dienTich << endl;*/

	//BAI5
	/*int n, gio, phut, giay;
	cout << "Nhap vao so giay: ";
	cin >> n;
	cout << endl << "=== KET QUA ===" << endl;
	//
	gio = n / MAX,
		phut = (n % MAX) / SIXTY,
			giay = (n % MAX) % SIXTY;
	cout << n << " giay duoc quy doi thanh: "
		<< gio << ":" << phut << ":" << giay 
		<< " (" << gio << " gio " << phut << " phut " << giay << " giay)" << "."
		<< endl;*/

	//BAI6
	/*int x, y;
	int a, b, c;
	cout << "Nhap x: ";
	cin >> x;
	cout << "Nhap y: ";
	cin >> y;
	cout << x++ << endl
		<< x-- << endl
		<< ++x << endl
		<< --x << endl;
	a = x = x / y;
	b = y = x % y;
	c = x *= y;
	cout << a << endl << b << endl << c << endl;*/

	//BAI7 - ERROR
	/*int n, count = 0;
	cout << "Nhap vao toi da 10 so: ";
	cin >> n;
	
	for(count; count < 11; count ++)
	if (n <= 0)
		cout << "ERROR! Vui long nhap so tu 0 tro len !";
	if (n != count)
		cout << "ERROR! Vui long nhap toi da 10 so !";
	else
		cout << "So vua nhap la: " << n << endl;*/
	
	//BAI8
	/*float x, y;
	int n, kq;
	cout << "Nhap vao x: ";
	cin >> x;
	cout << "Nhap vao y: ";
	cin >> y;
	cout << "Nhap vao so mu n: ";
	cin >> n;
	cout << endl << "=== KET QUA===" << endl;

	kq = pow(x, n) + pow(y, n);
	cout << "CT: x^n + y^n\n" << "Ket qua luy thua la: [" << kq << "]" << endl;*/

	//BAI9
	/*int a, b, h, p, canhBen;
	float chuVi, dienTich;
	//
	cout << "Nhap vao do dai day lon: ";
	cin >> a;
	cout << "Nhap vao do dai day be: ";
	cin >> b;
	cout << "Nhap vao chieu cao: ";
	cin >> h;

	p = (a - b) / 2;
	canhBen = sqrt(pow(p, 2) + pow(h, 2));
	chuVi = (a + b + 2) * canhBen;
	dienTich = ((a + b) * h) / 2;
	//
	cout << "=== KET QUA ===" << endl;
	cout << "Chu vi hinh thang: " << chuVi << ", " << "dien tich hinh thang: " << dienTich << "." << endl;
	cout << "==============";*/

	//BAI10
	/*for (int i = 0; i < 61; i++)
	{
		cout << "=";
	}
	cout << setiosflags(ios::left)
	<< endl
	<< setw(10) << "MSSV"
	<< setw(25) << "HO TEN"
	<< setw(10) << "KHOA"
	<< setw(10) << "DIEM"
	<< endl;
	//
	cout << setiosflags(ios::left)
	<< setw(10) << "-----"
	<< setw(25) << "-------------------"
	<< setw(10) << "-----"
	<< setw(10) << "----"
	<< endl;
	//
	cout << setiosflags(ios::left)
	<< setw(10) << "1211520"
	<< setw(25) << "Le Duy Tung"
	<< setw(10) << "33"
	<< setw(10) << "4.57"
	<< endl;
	//
	cout << setiosflags(ios::left)
	<< setw(10) << "1210152"
	<< setw(25) << "Tran Van Tien"
	<< setw(10) << "34"
	<< setw(10) << "VT"
	<< endl;
	//
	cout << setiosflags(ios::left)
	<< setw(10) << "......."
	<< setw(25) << "..................."
	<< setw(10) << "....."
	<< setw(10) << "...."
	<< endl;
	//
	cout << setiosflags(ios::left)
	<< setw(10) << "1211519"
	<< setw(25) << "Nguyen Tan Tai"
	<< setw(10) << "34"
	<< setw(10) << "2.89"
	<< endl;
	//
	for (int i = 0; i < 61; i++)
	{
		cout << "=";
	}
	cout << "\n";*/

	//BAI11 - HINH TRU TRON
	/*float r, h, cv, v
		, dtMatDay, dtXungQuanh, dtToanPhan;
	float PI = 3.14;
	//
	cout << "Nhap vao ban kinh mat day: ";
	cin >> r;
	cout << "Nhap vao chieu cao hinh tru tron: ";
	cin >> h;
	//
	v = PI * pow(r, 2) * h;
	dtXungQuanh = 2 * PI * r * h;
	dtToanPhan = (2 * PI * r * h) + (2 * PI * pow(r, 2));
	cv = pow(r, 2) * PI;
	dtMatDay = PI * pow(r, 2);
	//
	cout << "\n===== KET QUA =====\n";
	cout << "-\tChu vi hinh tru tron la: " << cv << endl;
	cout << "-\tDien tich mat day tru tron la: " << dtMatDay << endl;
	cout << "-\tDien tich xung quanh tru tron la: " << dtXungQuanh << endl;
	cout << "-\tDien tich toan phan tru tron la: " << dtToanPhan << endl;
	cout << "-\tThe tich cua tru tron la: " << v;
	cout << "\n==================\n";*/

	//BAI12 - HINH CAU
	/*int R;
	float sMatCau, vKhoiCau;
	float PI = 3.14;
	//
	cout << "Nhap vao ban kinh hinh cau(R): ";
	cin >> R;
	vKhoiCau = (4 / 3) * PI * pow(R, 3);
	sMatCau = 4 * PI * pow(R, 2);
	//
	cout << "\n===== KET QUA =====\n";
	cout << "Dien tich mat cau: " << sMatCau << ", " << "the tich khoi cau: " << vKhoiCau << "." << endl;
	cout << "===================\n";*/

	/*	BTTHEM */
	//BAI1
	/*int a, b, t, kq;
	cout << "Nhap a: ";
	cin >> a;
	t = a,
	b = t,
	kq = a = b;*/
	/*int a, b, t, kq;
	cout << "b= ";
	cin >> b;
	cout << "a= ";
	cin >> a;
	t = a, a = b, kq = b = t;
	cout << kq;*/

	//BAI2 - BMI
	/*float w, h;
	int BMI;
	cout << "=== BODY MASS INDEX ===\n";
	cout << "Nhap vao can nang: ";
	cin >> w;
	cout << "Nhap vao chieu cao: ";
	cin >> h;
	BMI = w / pow(h, 2);
	//
	cout << "Chi so BMI cua ban la: " << BMI << endl;
	cout << "===========================\n";*/

	//BAI3 - ERROR
	float A, B, a, b, d, x, y;

	cout << "Nhap vao toa do diem A: ";
	cin >> A;
	cout << "Nhap vao toa do diem B: ";
	cin >> B;

	d = sqrt(pow((x * b - x * a), 2) + pow((y * b - y * a), 2));

	cout << "\nKhoang cach: [" << d << "].";




	
	_getch();
	return 1;
}