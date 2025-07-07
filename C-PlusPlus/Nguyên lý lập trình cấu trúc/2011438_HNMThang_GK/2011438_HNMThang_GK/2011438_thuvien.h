#define SIZE 5
#define TAB '\t'
typedef int MaTranVuong[SIZE][SIZE];
void NhapMaTran(MaTranVuong a, int n)
{
	srand(time(NULL));
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < n; j++)
		{
			a[i][j] = rand() % (4 + 4 + 1) - 4;
		}
	}
}

void XuatMaTran(MaTranVuong a, int n)
{
	int i, j;
	for (i = 0; i < n; i++)
	{
		cout << "\n";
		for (j = 0; j < n; j++)
			cout << a[i][j] << TAB;
	}
}
int TinhTong_Cotj(MaTranVuong a, int n, int j)
{
	int i, sum;
	sum = 0;
	for (i = 0; i < n; i++)
		sum += a[i][j];
	return sum;
}
int TinhTich_Hangi(MaTranVuong a, int n, int i)
{
	int p, j;
	p = 1;
	for (j = 0; j < n; j++)
		p *= a[i][j];
	return p;
}
