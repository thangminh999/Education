#pragma once

#define MAX 10
#define TAB '\t'

typedef int DaySo[MAX];

void NhapMangTuDong(DaySo a, int &n);
void XuatMang(DaySo a, int n);
void SoDuongTangDan(DaySo a, int n);

void NhapMangTuDong(DaySo a, int &n)
{
	do
	{
		cout << "\nNhap vao kich thuoc cua mang ";
		cin >> n;
	} while (n <= 0);

	srand((unsigned)time(NULL));
	for (int i = 0; i < n; i++)
		a[i] = (MAX / 2 - rand() % MAX);
}

void XuatMang(DaySo a, int n)
{
	setiosflags(ios::left);
	for (int i = 0; i < n; i++)
	{
		cout << setw(3) << a[i] << TAB;
		if ((i + 1) % 10 == 0)
			cout << "\n";
	}
}
//cau 3
void TinhTong(DaySo a, int n)
{
	int sum = 0;
	for (int i = 0; i < n; i++)
	{
		sum += a[i];
	}
	cout << sum;
}
//cau 4
void soNhoNhat(DaySo a, int n)
{
	int min = a[0];
	for (int i = 0; i < n; i++)
	{
		if (a[i] <= min)
			min = a[i];
	}
	cout << min;
}
//cau 5
void VTsoNhoNhat(DaySo a, int n)
{
	int temp;
	int min = a[0];
	for (int i = 0; i < n; i++)
	{
		if (a[i] <= min) {
			min = a[i];
			temp = i + 1;
		}
	}
	cout << min
		<< " vi tri : "
		<< temp;

}



//cau6


