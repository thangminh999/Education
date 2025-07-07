
#define MAX 100 

struct hocvien
{
	char maHV[8];
	char hoHV[10];
	char tenLot[10];
	char ten[10];
	char lop[6];
	int namSinh;
	double dtb;
	int tinChi;
};

int File_Array(char *filename, hocvien a[MAX], int &n)
{
	ifstream in(filename);
	if (!in)
		return 0;
	char maSV[8];
	char hoSV[10];
	char tenLot[10];
	char ten[10];
	char lop[6];
	int namSinh;
	double dtb;
	int tinChi;
	n = 0;
	in >> maSV; strcpy_s(a[n].maHV, maSV);
	in >> hoSV; strcpy_s(a[n].hoHV, hoSV);
	in >> tenLot; strcpy_s(a[n].tenLot, tenLot);
	in >> ten; strcpy_s(a[n].ten, ten);
	in >> lop; strcpy_s(a[n].lop, lop);
	in >> namSinh; a[n].namSinh = namSinh;
	in >> dtb; a[n].dtb = dtb;
	in >> tinChi; a[n].tinChi = tinChi;
	while (!in.eof())
	{
		in >> a[n].maHV;
		in >> a[n].hoHV;
		in >> a[n].tenLot;
		in >> a[n].ten;
		in >> a[n].lop;
		in >> a[n].namSinh;
		in >> a[n].dtb;
		in >> a[n].tinChi;
		n++;
	}
	in.close();
	return 1;
}

void TieuDe()
{
	int i;
	cout << "\n";
	cout << ':';
	for (i = 1; i <= 74; i++)
		cout << '=';
	cout << ':';
	cout << "\n";
	cout << setiosflags(ios::left);
	cout << ':';
	cout << setw(9) << "Ma HV"
		<< ':'
		<< setw(30) << " Ho va Ten "
		<< ':'
		<< setw(10) << "Lop"
		<< ':'
		<< setw(6) << "Nam sinh"
		<< ':'
		<< setw(6) << "DTB"
		<< ':'
		<< setw(8) << "Tin chi"
		<< ':';
	cout << "\n";
	cout << ':';
	for (i = 1; i <= 74; i++)
		cout << '=';
	cout << ':';
	cout << "\n";
}

void Xuat_HV(hocvien p)
{
	cout << ':';
	cout << setiosflags(ios::left)
		<< setw(9) << p.maHV
		<< ':'
		<< setw(10) << p.hoHV
		<< setw(10) << p.tenLot
		<< setw(10) << p.ten
		<< ':'
		<< setw(10) << p.lop
		<< ':'
		<< setw(6) << p.namSinh
		<< ':'
		<< setw(6) << setiosflags(ios::fixed) << setprecision(2) << p.dtb
		<< ':'
		<< setw(8) << p.tinChi
		<< ':';
}

void Xuat_DSHV(hocvien a[MAX], int n)
{
	int i;
	TieuDe();
	for (i = 0; i < n; i++)
	{
		Xuat_HV(a[i]);
		cout << '\n';
	}
	cout << ':';
	for (i = 1; i <= 74; i++)
		cout << '=';
	cout << ':';
	cout << "\n";
}
void HoanVi(int &a, int &b)
{
	int tam = a;
	a = b;
	b = tam;
}
void Copy(hocvien b[MAX], hocvien a[MAX], int n)
{
	for (int i = 0; i < n; i++)
	{
		b[i] = a[i];
	}
}
void Selection(hocvien a[MAX], int& n)
{
	int i, j, cs_min;
	for (i = 0; i < n - 1; i++)
	{
		cs_min = i;
		for (j = i + 1; j < n; j++)
			if (_strcmpi(a[cs_min].maHV, a[j].maHV) > 0)
				cs_min = j;
		swap(a[i], a[cs_min]);
	}
}

void Partition(hocvien a[MAX], int l, int r)
{
	int i, j;
	hocvien x;
	x = a[(l + r) / 2];
	i = l; j = r;
	do
	{
		while (a[i].maHV < x.maHV)
			i++;
		while (a[j].maHV > x.maHV)
			j--;
		if (i <= j)
		{
			swap(a[i], a[j]);
			i++; j--;
		}
	} while (i <= j);
	if (l < j)
		Partition(a, l, j);
	if (i < r)
		Partition(a, i, r);
}
void QuickSort(hocvien a[MAX], int& n)
{
	Partition(a, 0, n - 1);

}
void SapXepTheoYeuCau(hocvien a[MAX], int n)
{
	for (size_t i = 0; i < n - 1; i++)
	{
		for (size_t j = i + 1; j < n; j++)
		{
			if (_strcmpi(a[i].ten, a[j].ten) > 0)
				swap(a[i], a[j]); if (_strcmpi(a[i].ten, a[j].ten) == 0)
			{
				if (_strcmpi(a[i].hoHV, a[j].hoHV) > 0)
				{
					swap(a[i], a[j]);
				}
			}
			if (_strcmpi(a[i].ten, a[j].ten) == 0 && _strcmpi(a[i].hoHV, a[j].hoHV) == 0)
			{
				if (_strcmpi(a[i].tenLot, a[j].tenLot) > 0)
				{
					swap(a[i], a[j]);
				}
			}
		}
	}
}